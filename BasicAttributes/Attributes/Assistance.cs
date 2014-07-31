using System.ComponentModel;

namespace BasicAttributes.Attributes
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Assistance
	{
		private bool _AsHintObject = false;
		[Category("Assistance")]
		[Description("Set to YES to turn this component a hint object.")]
		[DefaultValue(false)]
		public bool AsHintObject {
			get {
				return _AsHintObject;
			}
			set {
				_AsHintObject = value;
			}
		}
	}
}
