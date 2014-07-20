using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using StockComponents;

using System.Reflection;
using System.ComponentModel;
using System.Reflection.Emit;
using System.Threading;

namespace FormTest
{
	public partial class BaseForm : Form
	{
		public BaseForm( ) {
			InitializeComponent();

			StockComponents.Button testBtn = new StockComponents.Button();
			//testBtn.FontSize = 12;

			//PropertyInfo propertyInfo = new PropertyInfo();

			Console.WriteLine( "==PRINT INFO==" );
			foreach( PropertyInfo dummy in testBtn.GetType().GetProperties() )
			{
				string categoryName = dummy.Name;
				PropertyInfo[] properties = dummy.PropertyType.GetProperties();
				Console.WriteLine( categoryName + " :: " + properties.Length );
			}
			Console.WriteLine("==END PRINTING==");

			//propertyGrid.SelectedObject = testBtn;
			propertyGrid.SelectedObject = this.BuildDynamicClass( testBtn );
		}

		protected object BuildDynamicClass( StockComponents.Button target ) {
			// Define the dynamic assembly, module and type
			AssemblyName assemblyName = new AssemblyName( "DynamicAssembly" );
			AssemblyBuilder assemblyBuilder =
				Thread.GetDomain().DefineDynamicAssembly( assemblyName, AssemblyBuilderAccess.Run );
			ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule( "DynamicModule" );
			TypeBuilder typeBuilder = moduleBuilder.DefineType( "DynamicType", TypeAttributes.Public );

				// Create dynamic properties corresponding to query results
				foreach( PropertyInfo category in target.GetProperties() )
				{
					foreach( PropertyInfo attributes in category.PropertyType.GetProperties() )
					{
						Type dataType = Type.GetType( attributes.GetType().ToString() );

						this.BuildProperty( typeBuilder,
												attributes.Name,
												category.Name,
												"No description yet.",
												dataType );
					}
					
					//string name = (string)row[ "name" ];
					//string category = (string)row[ "category" ];
					//string description = (string)row[ "description" ];
					//Type dataType = Type.GetType( (string)row[ "data_type" ] );

					//this.BuildProperty( typeBuilder, name, category, description, dataType );
				}

				// Create and instantiate the dynamic type
				Type type = typeBuilder.CreateType();
				Object dynamicType = Activator.CreateInstance( type, new object[] { } );

				// Set each property's default value
				//foreach( DataRow row in dt.Rows )
				//{
				//    string name = (string)row[ "name" ];
				//    Type dataType = Type.GetType( (string)row[ "data_type" ] );
				//    object value = row[ "value" ];

				//    value = ( Convert.IsDBNull( value ) ) ? null : Convert.ChangeType( value, dataType );
				//    type.InvokeMember( name,
				//                        BindingFlags.SetProperty,
				//                        null,
				//                        dynamicType,
				//                        new object[] { value } );
				//}

				return dynamicType;
			
		}

		protected void BuildProperty(TypeBuilder typeBuilder,
										string name,
										string category,
										string description,
										Type fieldType) {
			// Generate the private field/public property name pair 
			// (field begins w/LC, property begins w/UC)
			char[] chars = name.ToCharArray();

			chars[ 0 ] = char.ToLower( chars[ 0 ] );
			string fieldName = new string( chars );

			chars[ 0 ] = char.ToUpper( chars[ 0 ] );
			string propertyName = new string( chars );

			// Create the private field
			FieldBuilder fieldBuilder = typeBuilder.DefineField( name,
																	fieldType,
																	FieldAttributes.Private );

			// Create the corresponding public property
			PropertyBuilder propertyBuilder =
				typeBuilder.DefineProperty( propertyName,
											System.Reflection.PropertyAttributes.HasDefault,
											fieldType,
											null );

			// Define the required set of property attributes
			MethodAttributes propertyAttributes = MethodAttributes.Public |
													MethodAttributes.SpecialName |
													MethodAttributes.HideBySig;

			// Build the getter
			MethodBuilder getter = typeBuilder.DefineMethod( "get_" + propertyName,
																propertyAttributes,
																fieldType,
																Type.EmptyTypes );
			ILGenerator getterIlGen = getter.GetILGenerator();
			getterIlGen.Emit( OpCodes.Ldarg_0 );
			getterIlGen.Emit( OpCodes.Ldfld, fieldBuilder );
			getterIlGen.Emit( OpCodes.Ret );

			// Build the setter
			MethodBuilder setter = typeBuilder.DefineMethod( "set_" + propertyName,
																propertyAttributes,
																null,
																new Type[] { fieldType } );
			ILGenerator setterIlGen = setter.GetILGenerator();
			setterIlGen.Emit( OpCodes.Ldarg_0 );
			setterIlGen.Emit( OpCodes.Ldarg_1 );
			setterIlGen.Emit( OpCodes.Stfld, fieldBuilder );
			setterIlGen.Emit( OpCodes.Ret );

			// Bind the getter and setter
			propertyBuilder.SetGetMethod( getter );
			propertyBuilder.SetSetMethod( setter );

			// Set the Category and Description attributes
			propertyBuilder.SetCustomAttribute(
				new CustomAttributeBuilder(
					typeof( CategoryAttribute ).GetConstructor(
						new Type[] { typeof( string ) } ), new object[] { category } ) );
			propertyBuilder.SetCustomAttribute(
				new CustomAttributeBuilder(
					typeof( DescriptionAttribute ).GetConstructor(
						new Type[] { typeof( string ) } ), new object[] { description } ) );
		}
	}
}