using System.ComponentModel;

namespace BasicAttributes.Attributes
{
	[TypeConverter( typeof( ExpandableObjectConverter ) )]
	public class VisionDetail
	{
		private int _CameraID;
		[Category("Vision Detail")]
		[Description("ID of the designated camera.")]
		public int CameraID {
			get {
				return _CameraID;
			}
			set {
				_CameraID = value;
			}
		}

		public override string ToString( ) {
			return string.Empty;
		}
	}
}
