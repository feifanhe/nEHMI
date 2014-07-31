using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

using BasicAttributes.Helper;

using System.Reflection;

namespace BasicAttributes.Attributes
{
	[Category("Collection")]
	[Description( "Expand the list to show all the items." )]
	[TypeConverter( typeof( ExpandableObjectConverter ) )]
	public class Collection : CollectionBase, ICustomTypeDescriptor
	{
		private Type _ContentType;

		public Collection(Type ContentType) {
			this._ContentType = ContentType;
		}

		#region ICustomTypeDescriptor Members

		public String GetClassName( ) {
			return TypeDescriptor.GetClassName( this, true );
		}

		public AttributeCollection GetAttributes( ) {
			return TypeDescriptor.GetAttributes( this, true );
		}

		public String GetComponentName( ) {
			return TypeDescriptor.GetComponentName( this, true );
		}

		public TypeConverter GetConverter( ) {
			return TypeDescriptor.GetConverter( this, true );
		}

		public EventDescriptor GetDefaultEvent( ) {
			return TypeDescriptor.GetDefaultEvent( this, true );
		}

		public PropertyDescriptor GetDefaultProperty( ) {
			return TypeDescriptor.GetDefaultProperty( this, true );
		}

		public object GetEditor(Type editorBaseType) {
			return TypeDescriptor.GetEditor( this, editorBaseType, true );
		}

		public EventDescriptorCollection GetEvents(Attribute[] attributes) {
			return TypeDescriptor.GetEvents( this, attributes, true );
		}

		public EventDescriptorCollection GetEvents( ) {
			return TypeDescriptor.GetEvents( this, true );
		}

		public object GetPropertyOwner(PropertyDescriptor pd) {
			return this;
		}

		public PropertyDescriptorCollection GetProperties(Attribute[] attributes) {
			return GetProperties();
		}

		public PropertyDescriptorCollection GetProperties( ) {
			// Create a new DummyCollection object PropertyDescriptorCollection
			PropertyDescriptorCollection pds = new PropertyDescriptorCollection( null );

			// Iterate the list of items
			for( int i = 0; i < this.List.Count; i++ )
			{
				// For each employee create a property descriptor 
				// and add it to the 
				// PropertyDescriptorCollection instance
				CollectionPropertyDescriptor cpd = new
							  CollectionPropertyDescriptor( this, i );
				pds.Add( cpd );
			}
			return pds;
		}

		#endregion

		#region CollectionBase Members

		//public void Add(object Item) {
		//    this.List.Add( Item );
		//}
		public void Add(string ItemName) {
			this.List.Add( Activator.CreateInstance(_ContentType, new object[]{ ItemName}));
		}
		public void Remove(object Item) {
			this.List.Remove( Item );
		}
		//public void Remove(string ItemName) {
		//    for( int i = 0; i < this.List.Count; i++ )
		//    {
		//        if( Convert.ChangeType(this.List[ i ], _ContentType).Common.Name == ItemName )
		//        {
		//            this.List.RemoveAt( i );
		//            return;
		//        }
		//    }
		//    //this.List.Remove( Activator.CreateInstance( _ContentType, new object[] { ItemName } ) );
		//}
		public object this[ int index ] {
			get {
				return this.List[ index ];
			}
		}

		#endregion

		public override string ToString( ) {
			return string.Empty;
		}
	}
}
