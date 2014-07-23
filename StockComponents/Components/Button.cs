using System;
using System.Collections.Generic;
using BasicAttributes;
using System.ComponentModel;
using System.Reflection;

namespace StockComponents
{
	public class Button //: IText
	{
		private AttributesPacker packed = new AttributesPacker();

		private Text _Text = new Text();
		private Image _Image = new Image();

		public Text Text {
			get {
				return _Text;
			}
		}

		public Image Image {
			get {
				return _Image;
			}
		}

		public AttributesPacker Properties {
			get {
				packed.Clear();
				packed.Add( _Text );
				packed.Add( _Image );
				return packed;
			}
		}
	}
}
