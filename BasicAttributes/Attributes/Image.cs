using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BasicAttributes
{
	public class Image
	{
		private string _Source;
		private bool _TransparentBackground;
		private Justification _Alignment;

		[Category("Image")]
		[Description("The path of the shown image.")]
		public string Source {
			get {
				return _Source;
			}
			set {
				this._Source = value;
			}
		}

		[Category( "Image" )]
		[Description("Checked to have transparent color for the image. GIF only.")]
		public bool TransparentBackground {
			get {
				return _TransparentBackground;
			}
			set {
				this._TransparentBackground = value;
			}
		}

		[Category( "Image" )]
		[Description("Set the alignment of the image displayed.")]
		public Justification Alignment {
			get {
				return _Alignment;
			}
			set {
				this._Alignment = value;
			}
		}
	}
}
