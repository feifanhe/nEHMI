using System;
using System.ComponentModel;

using BasicAttributes.Attributes;

namespace BasicAttributes.Helper
{
	public class CollectionPropertyDescriptor : PropertyDescriptor
	{
		private Collection collection = null;
		private int index = -1;

		public CollectionPropertyDescriptor(Collection coll, int idx)
			: base( "#" + idx.ToString(), null ) {
			this.collection = coll;
			this.index = idx;
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

		public override string DisplayName {
			get {
				object emp = this.collection[ index ];
				return "OBJECT " + index.ToString();
			}
		}

		public override string Description {
			get {
				//Employee emp = this.collection[ index ];
				//StringBuilder sb = new StringBuilder();
				//sb.Append( emp.LastName );
				//sb.Append( "," );
				//sb.Append( emp.FirstName );
				//sb.Append( "," );
				//sb.Append( emp.Age );
				//sb.Append( " years old, working for " );
				//sb.Append( emp.Department );
				//sb.Append( " as " );
				//sb.Append( emp.Role );

				//return sb.ToString();
				return "DESCRIPTION FOR OBJECT " + index.ToString();
			}
		}

		public override object GetValue(object component) {
			return this.collection[ index ];
		}

		public override bool IsReadOnly {
			get {
				return true;
			}
		}

		public override string Name {
			get {
				return "#" + index.ToString();
			}
		}

		public override Type PropertyType {
			get {
				return this.collection[ index ].GetType();
			}
		}

		public override void ResetValue(object component) {
		}

		public override bool ShouldSerializeValue(object component) {
			return true;
		}

		public override void SetValue(object component, object value) {
			// this.collection[index] = value;
		}
	}
}
