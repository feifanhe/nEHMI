using BasicAttributes.Attributes;

namespace StockComponents
{
	public class CheckBox
	{
		private Common _Common = new Common();
		public Common Common {
			get {
				return _Common;
			}
			set {
				_Common = value;
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

		private Indicator _Indicator = new Indicator();
		public Indicator Indicator {
			get {
				return _Indicator;
			}
			set {
				_Indicator = value;
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
	}
}
