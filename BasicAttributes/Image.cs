using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAttributes
{
	abstract class Image
	{
		private string _Source;
		private bool _TransparentBackground;
		private Justification _Alignment;

		public string Source {
			get {
				return _Source;
			}
			set {
				this._Source = value;
			}
		}

		public bool TransparentBackground {
			get {
				return _TransparentBackground;
			}
			set {
				this._TransparentBackground = value;
			}
		}

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
