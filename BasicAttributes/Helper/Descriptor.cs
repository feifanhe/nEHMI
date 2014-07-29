using System;
using System.ComponentModel;

using BasicAttributes.Attributes;

namespace BasicAttributes.Helper
{
	public class CustomeCollectionPropertyDescriptor : PropertyDescriptor
	{
		private Collection collection = null;
		private int index = -1;

		public CustomeCollectionPropertyDescriptor(Collection TargetItem, int index)
			: base( "Item " + index.ToString(), null ) {
			this.collection = TargetItem;
			this.index = index;
		}

		public override AttributeCollection Attributes {
			get {
				return new AttributeCollection( null );
			}
		}

		public override bool CanResetValue(object component) {
			return true;
		}

		public override Type ComponentType {
			get {
				return this.collection.GetType();
			}
		}

		public override object GetValue(object component) {
			return this.collection[ index ];
		}

		public override bool IsReadOnly {
			get {
				return false;
			}
		}

		public override Type PropertyType {
			get {
				return this.collection[ index ].GetType();
			}
		}

		public override void ResetValue(object component) {
		}

		public override void SetValue(object component, object value) {
		}

		public override bool ShouldSerializeValue(object component) {
			return true;
		}

		public override string Name {
			get {
				return "Item " + index.ToString();
			}
		}
	}
}
