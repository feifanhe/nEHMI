using System.ComponentModel;

using BasicAttributes.Attributes;
using StockComponents.Helper;

namespace StockComponents
{
	[TypeConverter( typeof( ItemConverter ) )]
	public class Label
	{
		public Label(string name) {
			this._Common.Name = name;
		}
		
		private Common _Common = new Common();
		public Common Common {
			get {
				return _Common;
			}
			set {
				_Common = value;
			}
		}

		private Assistance _Assitance = new Assistance();
		public Assistance Assitance {
			get {
				return _Assitance;
			}
			set {
				_Assitance = value;
			}
		}

		private Text _Text = new Text();
		public Text Text {
			get {
				return _Text;
			}
			set {
				_Text = value;
			}
		}
	}
}
