using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAttributes
{
	abstract class Image
	{
		private string _Source;
		private int _TransparentBackground;

		protected internal string Source {
			get {
				return _Source;
			}
			set {
				this._Source = value;
			}
		}

		protected internal int Justification {
			get {
				throw new System.NotImplementedException();
			}
			set {
			}
		}

		protected internal bool TransparentBackground {
			get {
				throw new System.NotImplementedException();
			}
			set {
			}
		}
	}
}
