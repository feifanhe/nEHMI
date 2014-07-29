using System.ComponentModel;

using BasicAttributes.Attributes;

namespace StockComponents
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Picture
	{
		public Picture(string name) {
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

		private Assistance _Assistance = new Assistance();
		public Assistance Assistance {
			get {
				return _Assistance;
			}
			set {
				_Assistance = value;
			}
		}

		private Image _Image = new Image();
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
