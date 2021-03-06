using System.ComponentModel;

namespace BasicAttributes.Attributes
{
	[TypeConverter( typeof( ExpandableObjectConverter ) )]
	public class Image
	{
		private string _Source = string.Empty;
		[Category( "Image" )]
		[Description( "The path of the shown image." )]
		public string Source {
			get {
				return _Source;
			}
			set {
				this._Source = value;
			}
		}

		private bool _AllowTransparent = false;
		[Category( "Image" )]
		[Description( @"Checked to have transparent color for the image.
						This option can only apply to GIF images." )]
		[DefaultValue( false )]
		public bool AllowTransparent {
			get {
				return _AllowTransparent;
			}
			set {
				this._AllowTransparent = value;
			}
		}

		private Justification _Alignment = Justification.MiddleCenter;
		[Category( "Image" )]
		[Description( "Set the alignment of the image displayed." )]
		[DefaultValue( Justification.MiddleCenter )]
		public Justification Alignment {
			get {
				return _Alignment;
			}
			set {
				this._Alignment = value;
			}
		}

		public override string ToString( ) {
			return string.Empty;
		}
	}
}
