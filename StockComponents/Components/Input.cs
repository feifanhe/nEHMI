using BasicAttributes.Attributes;

namespace StockComponents
{
	public class Input
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

		private InputDetail _InputDetail = new InputDetail();
		public InputDetail Detail {
			get {
				return _InputDetail;
			}
		}
	}
}
