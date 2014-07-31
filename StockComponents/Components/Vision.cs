using BasicAttributes.Attributes;

namespace StockComponents
{
	public class Vision
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

		private VisionDetail _Vision = new VisionDetail();
		public VisionDetail Detail {
			get {
				return _Vision;
			}
			set {
				_Vision = value;
			}
		}
	}
}
