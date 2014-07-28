using BasicAttributes.Attributes;

namespace StockComponents
{
	class Picture
	{
		private Common _Common;
		public Common Common {
			get {
				return _Common;
			}
			set {
				_Common = value;
			}
		}

		private Assistance _Assistance;
		public Assistance Assistance {
			get {
				return _Assistance;
			}
			set {
				_Assistance = value;
			}
		}

		private Image _Image;
		public Image Image {
			get {
				return _Image;
			}
			set {
				_Image = value;
			}
		}
	}
}
