using System.ComponentModel;

using BasicAttributes.Helper;

namespace BasicAttributes.Attributes
{
	[TypeConverter( typeof( ExpandableObjectConverter ) )]
	public class Indicator
	{
		private Format _Format;
		[Category( "Display" )]
		[Description( "The represent format of the numbers in registry." )]
		[TypeConverter( typeof( EnumDescriptionConverter ) )]
		public Format Format {
			get {
				return _Format;
			}
			set {
				_Format = value;
			}
		}

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

		public override string ToString( ) {
			return string.Empty;
		}
	}
}
