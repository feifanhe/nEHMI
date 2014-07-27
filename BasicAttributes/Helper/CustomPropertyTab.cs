using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Collections;

namespace BasicAttributes.Helper
{
	public class CustomPropertyTab : System.Windows.Forms.Design.PropertyTab
	{
		public override PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes) {
			return GetProperties( null, component, attributes );
		}

		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object component, Attribute[] attributes) {

			//target = uc; // uc = component as FunkyButton
			// our list of props.
			//
			ArrayList propList = new ArrayList();

			// add the property for our count of vertices
			//
			//propList.Add( new NumPointsPropertyDescriptor( this ) );

			//// add a property descriptor for each vertex
			////
			//for( int i = 0; i < ( (FunkyButton)component ).Points.Count; i++ )
			//{
			//    propList.Add( new VertexPropertyDescriptor( this, i ) );
			//}

			// return the collection of PropertyDescriptors.
			PropertyDescriptor[] props = (PropertyDescriptor[])propList.ToArray( typeof( PropertyDescriptor ) );
			return new PropertyDescriptorCollection( props );
		
		}

		public override string TabName {
			get {
				return "CUSTOM PROPERTY TAB";
			}
		}

		public override Bitmap Bitmap {
			get {
				// force this to 16x16 to work around a Beta2 PropertyGrid
				// issue.
				return new Bitmap( base.Bitmap, new Size( 16, 16 ) );
			}
		}
	}
}
