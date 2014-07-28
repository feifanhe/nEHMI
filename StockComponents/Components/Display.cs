using BasicAttributes.Attributes;

namespace StockComponents
{
	public class Display
	{
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

		private Indicator _Indicator = new Indicator();
		public Indicator Indicator {
			get {
				return _Indicator;
			}
		}
	}
}
