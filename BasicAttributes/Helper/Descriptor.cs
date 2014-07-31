using System;
using System.ComponentModel;

using BasicAttributes.Attributes;

namespace BasicAttributes.Helper
{
	public class CollectionPropertyDescriptor : PropertyDescriptor
	{
		private Collection DummyCollection = null;
		private int Index = -1;
		object SelectedItem;

		public CollectionPropertyDescriptor(Collection InputCollection, int Index)
			: base( "#" + Index.ToString(), null ) {
			this.DummyCollection = InputCollection;
			this.Index = Index;
			this.SelectedItem = this.DummyCollection[ Index ];
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
				return SelectedItem.GetType();
			}
		}

		public override string DisplayName {
			get {
				return ComponentType.Name + " " + ( Index + 1 ).ToString();
			}
		}

		public override object GetValue(object component) {
			return SelectedItem;
		}

		public override bool IsReadOnly {
			get {
				return true;
			}
		}

		public override string Name {
			get {
				return "#" + Index.ToString();
			}
		}

		public override Type PropertyType {
			get {
				return this.DummyCollection[ Index ].GetType();
			}
		}

		public override void ResetValue(object component) {
		}

		public override bool ShouldSerializeValue(object component) {
			return true;
		}

		public override void SetValue(object component, object value) {
			// this.DummyCollection[Index] = value;
		}
	}
}
