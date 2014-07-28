using System.ComponentModel;

namespace BasicAttributes.Attributes
{
	public class Vision
	{
		private int _CameraID;
		[Category("Vision")]
		[Description("ID of the designated camera.")]
		public int CameraID {
			get {
				return _CameraID;
			}
			set {
				_CameraID = value;
			}
		}
	}
}
