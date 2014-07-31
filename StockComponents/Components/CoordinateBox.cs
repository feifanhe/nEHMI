using BasicAttributes.Attributes;

namespace StockComponents
{
	public class CoordinateBox
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

		private CoordinateDetail _CoordinateDetail = new CoordinateDetail();
		public CoordinateDetail Detail {
			get {
				return _CoordinateDetail;
			}
			set {
				_CoordinateDetail = value;
			}
		}
	}
}
