using System;
using System.Collections.Generic;
using BasicAttributes;
using System.ComponentModel;
using System.Reflection;

namespace StockComponents
{
	public class Button
	{
		private AttributesPacker packed = new AttributesPacker();

		private Common _Common = new Common();
		public Common Common {
			get {
				return _Common;
			}
		}

		private Text _Text = new Text();
		public Text Text {
			get {
				return _Text;
			}
		}

		private Image _Image = new Image();
		public Image Image {
			get {
				return _Image;
			}
		}

		public AttributesPacker Properties {
			get {
				packed.Clear();

				#region General Inclusion
				packed.Add( _Common );
				packed.Add( _Text );
				packed.Add( _Image );
				#endregion

				#region Exceptional Removal
				#endregion

				return packed;
			}
		}
	}
}
