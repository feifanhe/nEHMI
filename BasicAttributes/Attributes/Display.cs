using System.ComponentModel;

namespace BasicAttributes.Attributes
{
	public class Display
	{
		private Registry _SourceRegistry;

		[Category( "Display" )]
		[Description( "The registry that defined the display contents." )]
		public Registry SourceRegistry {
			get {
				return _SourceRegistry;
			}
			set {
				_SourceRegistry = value;
			}
		}
	}
}
