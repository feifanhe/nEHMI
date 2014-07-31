using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

using BasicAttributes.Attributes;
using BasicAttributes.Helper;

namespace StockComponents
{
	//[PropertyTab(typeof(CustomPropertyTab), PropertyTabScope.Component)]
	public class Button
	{
		private AttributesPacker packed = new AttributesPacker();

		private Common _Common = new Common();
		//[Browsable(false)]
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

		private ButtonDetail _ButtonDetail = new ButtonDetail();
		public ButtonDetail Detail {
			get {
				return _ButtonDetail;
			}
			set {
				_ButtonDetail = value;
			}
		}

		private Advance _Advance = new Advance();
		public Advance Advance {
			get {
				return _Advance;
			}
			set {
				_Advance = value;
			}
		}

		private Actions _Actions = new Actions();
		public Actions Actions {
			get {
				return _Actions;
			}
			set {
				_Actions = value;
			}
		}

		//public AttributesPacker Properties {
		//    get {
		//        packed.Clear();

		//        #region General Inclusion
		//        packed.Add( _Common );
		//        packed.Add( _Text );
		//        packed.Add( _Image );
		//        #endregion

		//        #region Exceptional Removal
		//        #endregion

		//        return packed;
		//    }
		//    set {
		//        packed = value;
		//    }
		//}
	}
}
