using System;
using System.Collections.Generic;
using System.Text;
using BasicAttributes;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;

namespace StockComponents
{
	public class Button //: IText
	{
		public Button(){
		}
		
		private Text _Text = new Text();
		[TypeConverter( typeof( ExpandableObjectConverter ) )]
		public Text Text {
			get {
				return _Text;
			}
		}

		private BasicAttributes.Image _Image = new BasicAttributes.Image();
		[TypeConverter( typeof( ExpandableObjectConverter ) )]
		public BasicAttributes.Image Image {
			get {
				return _Image;
			}
		}

		public object[] GetProperties( ) {
			//Type type = typeof( Person );
			//PropertyInfo[] properties = type.GetProperties();
			//foreach( PropertyInfo property in properties )
			//{
			//    Console.WriteLine( "{0} = {1}", property.Name, property.GetValue( person, null ) );
			//}

			return typeof( Button ).GetProperties();
		}

		//#region IText Members

		//private IText _Text = new Text();
		
		//public int FontSize {
		//    get {
		//        return _Text.FontSize;
		//    }
		//    set {
		//        _Text.FontSize = value;
		//    }
		//}

		//public Color TextColor {
		//    get {
		//        return _Text.TextColor;
		//    }
		//    set {
		//        _Text.TextColor = value;
		//    }
		//}

		//public bool Localizable {
		//    get {
		//        return _Text.Localizable;
		//    }
		//    set {
		//        _Text.Localizable = value;
		//    }
		//}

		//public Justification Alignment {
		//    get {
		//        return _Text.Alignment;
		//    }
		//    set {
		//        _Text.Alignment = value;
		//    }
		//}

		//#endregion
	}
}
