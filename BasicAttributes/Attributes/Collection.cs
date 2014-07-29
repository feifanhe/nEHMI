using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

using BasicAttributes.Helper;
using System.Reflection;

namespace BasicAttributes.Attributes
{
	
	public class Collection : CollectionBase, ICustomTypeDescriptor
	{
		private Type ContentType;
		private object holder;

		// Constructor for Collection class
		public Collection(Type ContentType) {
			this.ContentType = ContentType;

			Type generic = typeof( List<> );
			Type specific = generic.MakeGenericType( ContentType );
			ConstructorInfo ci = specific.GetConstructor( Type.EmptyTypes );
			holder = ci.Invoke( new object[] { } );
		}

		#region ICustomTypeDescriptor Members

		public AttributeCollection GetAttributes( ) {
			return TypeDescriptor.GetAttributes( this, true );
		}

		public string GetClassName( ) {
			return TypeDescriptor.GetClassName( this, true );
		}

		public string GetComponentName( ) {
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

		public object GetEditor(System.Type editorBaseType) {
			return TypeDescriptor.GetEditor( this, editorBaseType, true );
		}

		public EventDescriptorCollection GetEvents(System.Attribute[] attributes) {
			return TypeDescriptor.GetEvents( this, attributes, true );
		}

		public EventDescriptorCollection GetEvents( ) {
			return TypeDescriptor.GetEvents( this, true );
		}

		public PropertyDescriptorCollection GetProperties(System.Attribute[] attributes) {
			return GetProperties();
		}

		public PropertyDescriptorCollection GetProperties( ) {
			// Create a collection object to hold property descriptors
			PropertyDescriptorCollection pds = new PropertyDescriptorCollection( null );

			// Iterate the list of employees
			for( int i = 0; i < this.List.Count; i++ )
			{
				// Create a property descriptor for the employee item and add to the property descriptor collection
				CustomeCollectionPropertyDescriptor pd = new CustomeCollectionPropertyDescriptor( this, i );
				pds.Add( pd );
			}
			// return the property descriptor collection
			return pds;
		}

		public object GetPropertyOwner(PropertyDescriptor pd) {
			return this;
		}

		#endregion

		#region CollectionBase Members

		/// <summary>
		/// Adds an employee object to the collection
		/// </summary>
		/// <param name="emp"></param>
		public void Add<T>(T emp){
			this.List.Add( emp );
		}

		/// <summary>
		/// Removes an employee object from the collection
		/// </summary>
		/// <param name="emp"></param>
		public void Remove<T>(T emp) {
			this.List.Remove( emp );
		}

		/// <summary>
		/// Returns an employee object at index position.
		/// </summary>
		public object this[ int index ] {
			get {
				return Convert.ChangeType(this.List[ index ], ContentType);
			}
		}

		#endregion
	}
}
