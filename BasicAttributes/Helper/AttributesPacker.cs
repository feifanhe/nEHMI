using System;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace BasicAttributes.Helper
{
	/// <summary>
	/// AttributesPacker (Which is binding to property grid)
	/// </summary>
	public class AttributesPacker: CollectionBase,ICustomTypeDescriptor
	{
		public void Add(object target) {
			CustomProperty dummyProp;
			foreach( PropertyInfo property in target.GetType().GetProperties() )
			{
				dummyProp = new CustomProperty( property, target );
				Add( dummyProp );
			}
		}
		
		/// <summary>
		/// Add CustomProperty to Collectionbase List
		/// </summary>
		/// <param name="Value"></param>
		public void Add(CustomProperty Value)
		{
			base.List.Add(Value);
		}

		/// <summary>
		/// Remove item from List
		/// </summary>
		/// <param name="Name"></param>
		public void Remove(string Name)
		{
			foreach(CustomProperty prop in base.List)
			{
				if(prop.Name == Name)
				{
					base.List.Remove(prop);
					return;
				}
			}
		}

		/// <summary>
		/// Indexer
		/// </summary>
		public CustomProperty this[int index] 
		{
			get 
			{
				return (CustomProperty)base.List[index];
			}
			set
			{
				base.List[index] = (CustomProperty)value;
			}
		}


		#region "TypeDescriptor Implementation"
		/// <summary>
		/// Get Class Name
		/// </summary>
		/// <returns>String</returns>
		public String GetClassName()
		{
			return TypeDescriptor.GetClassName(this,true);
		}

		/// <summary>
		/// GetAttributes
		/// </summary>
		/// <returns>AttributeCollection</returns>
		public AttributeCollection GetAttributes()
		{
			return TypeDescriptor.GetAttributes(this,true);
		}

		/// <summary>
		/// GetComponentName
		/// </summary>
		/// <returns>String</returns>
		public String GetComponentName()
		{
			return TypeDescriptor.GetComponentName(this, true);
		}

		/// <summary>
		/// GetConverter
		/// </summary>
		/// <returns>TypeConverter</returns>
		public TypeConverter GetConverter()
		{
			return TypeDescriptor.GetConverter(this, true);
		}

		/// <summary>
		/// GetDefaultEvent
		/// </summary>
		/// <returns>EventDescriptor</returns>
		public EventDescriptor GetDefaultEvent() 
		{
			return TypeDescriptor.GetDefaultEvent(this, true);
		}

		/// <summary>
		/// GetDefaultProperty
		/// </summary>
		/// <returns>PropertyDescriptor</returns>
		public PropertyDescriptor GetDefaultProperty() 
		{
			return TypeDescriptor.GetDefaultProperty(this, true);
		}

		/// <summary>
		/// GetEditor
		/// </summary>
		/// <param name="editorBaseType">editorBaseType</param>
		/// <returns>object</returns>
		public object GetEditor(Type editorBaseType) 
		{
			return TypeDescriptor.GetEditor(this, editorBaseType, true);
		}

		public EventDescriptorCollection GetEvents(Attribute[] attributes) 
		{
			return TypeDescriptor.GetEvents(this, attributes, true);
		}

		public EventDescriptorCollection GetEvents()
		{
			return TypeDescriptor.GetEvents(this, true);
		}

		public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			PropertyDescriptor[] newProps = new PropertyDescriptor[this.Count];
			for (int i = 0; i < this.Count; i++)
			{

				CustomProperty  prop = (CustomProperty) this[i];
				newProps[i] = new CustomPropertyDescriptor(ref prop, attributes);
			}

			return new PropertyDescriptorCollection(newProps);
		}

		public PropertyDescriptorCollection GetProperties()
		{
			
			return TypeDescriptor.GetProperties(this, true);
			
		}

		public object GetPropertyOwner(PropertyDescriptor pd) 
		{
			return this;
		}
		#endregion
	
	}

	/// <summary>
	/// Custom property class 
	/// </summary>
	public class CustomProperty
	{
		private string _Name = string.Empty;
		private string _Category = string.Empty;
		private bool _ReadOnly = false;
		private bool _Visible = true;
		private object _Value = null;
		private string _Description = string.Empty;
		private TypeConverter _Converter;

		//public CustomProperty(PropertyInfo property, object target, TypeConverter Converter) {
		//    //CustomProperty( property, target );

		//    this._Name = property.Name;
		//    this._ReadOnly = false;
		//    this._Visible = true;
		//    this._Value = property.GetValue( target, null );
		//    this._Category = GetAttribute<CategoryAttribute>( property ).Category;
		//    this._Description = GetAttribute<DescriptionAttribute>( property ).Description;

		//    this._Converter = Converter;
		//}

		public CustomProperty(PropertyInfo property, object target)
		{
			this._Name = property.Name;
			this._ReadOnly = false;
			this._Visible = true;
			this._Value = property.GetValue( target, null );
			this._Category = GetAttribute<CategoryAttribute>( property ).Category;
			this._Description = GetAttribute<DescriptionAttribute>( property ).Description;

			TypeConverterAttribute TCA = GetAttribute<TypeConverterAttribute>( property );
			if( TCA != null )
			{
				//this._Converter = TypeDescriptor.GetConverter( typeof( LanguageConverter ) );
				this._Converter = new LanguageConverter();
			}

			/* 
			 * If null is an allowable option, change:
			 *		GetAttribute<attribute>( property ).detail;
			 * to:
			 *		( GetAttribute<attribute>( property ) ?? attribute.Default ).deteail;
			 * to avoid the NullReferenceException from showing.
			 */
		}

		private T GetAttribute<T>(PropertyInfo property) {
			object[] atts = property.GetCustomAttributes( typeof(T), false);
			if( atts.Length == 0 )
				return default(T);
			return (T)atts[ 0 ];
		}

		public bool ReadOnly {
			get {
				return _ReadOnly;
			}
		}

		public string Name {
			get {
				return _Name;
			}
		}

		public bool Visible {
			get {
				return _Visible;
			}
		}

		public object Value {
			get {
				return _Value;
			}
			set {
				_Value = value;
			}
		}

		public string Category {
			get {
				return _Category;
			}
		}

		public string Description {
			get {
				return _Description;
			}
		}

		public TypeConverter Converter {
			get {
				return _Converter;
			}
		}
	}


	/// <summary>
	/// Custom PropertyDescriptor
	/// </summary>
	public class CustomPropertyDescriptor: PropertyDescriptor
	{
		CustomProperty m_Property;
		public CustomPropertyDescriptor(ref CustomProperty myProperty, Attribute [] attrs) :base(myProperty.Name, attrs)
		{
			m_Property = myProperty;
		}

		#region PropertyDescriptor specific
		
		public override bool CanResetValue(object component)
		{
			return false;
		}

		public override Type ComponentType
		{
			get 
			{
				return null;
			}
		}

		public override object GetValue(object component)
		{
			return m_Property.Value;
		}

		public override string Description
		{
			get
			{
				return m_Property.Description;
			}
		}
		
		public override string Category
		{
			get
			{
				return m_Property.Category;
			}
		}

		public override string DisplayName
		{
			get
			{
				// pre-process display name whenever property grid callup the name
				return AddSpacesToSentence( m_Property.Name, true );
			}
		}
		private string AddSpacesToSentence(string text, bool preserveAcronyms) {
			if( string.IsNullOrEmpty( text ) )
				return string.Empty;
			StringBuilder newText = new StringBuilder( text.Length * 2 );
			newText.Append( text[ 0 ] );
			for( int i = 1; i < text.Length; i++ )
			{
				if( char.IsUpper( text[ i ] ) )
					if( ( text[ i - 1 ] != ' ' && !char.IsUpper( text[ i - 1 ] ) ) ||
						( preserveAcronyms && char.IsUpper( text[ i - 1 ] ) &&
						 i < text.Length - 1 && !char.IsUpper( text[ i + 1 ] ) ) )
						newText.Append( ' ' );
				newText.Append( text[ i ] );
			}
			return newText.ToString();
		}

		public override bool IsReadOnly
		{
			get
			{
				return m_Property.ReadOnly;
			}
		}

		public override void ResetValue(object component)
		{
			//Have to implement
		}

		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}

		public override void SetValue(object component, object value)
		{
			m_Property.Value = value;
		}

		public override Type PropertyType {
			get {
				return m_Property.Value.GetType();
			}
		}

		public override TypeConverter Converter {
			get {
				return m_Property.Converter;
			}
		}

		#endregion

			
	}
}
