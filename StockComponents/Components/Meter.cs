using BasicAttributes.Attributes;

namespace StockComponents
{
	public class Meter
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

		private MeterDetail _MeterDetail = new MeterDetail();
		public MeterDetail Detail {
			get {
				return _MeterDetail;
			}
			set {
				_MeterDetail = value;
			}
		}
	}
}
