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

		//public Image(string Source) {
		//    this._Source = Source;
		//}

		[Category("Image")]
		public string Source {
			get {
				return _Source;
			}
			set {
				this._Source = value;
			}
		}

		[Category( "Image" )]
		public bool TransparentBackground {
			get {
				return _TransparentBackground;
			}
			set {
				this._TransparentBackground = value;
			}
		}

		[Category( "Image" )]
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
