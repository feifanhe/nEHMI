using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace BasicAttributes
{
	public class Text
	{
		private int _FontSize;
		private Color _TextColor;
		private bool _Localizable;
		private Justification _Alignment;

		public Text( ) {
		}

		public int FontSize {
			get {
				return _FontSize;
			}
			set {
				this._FontSize = value;
			}
		}

		public Color TextColor {
			get {
				return _TextColor;
			}
			set {
				this._TextColor = value;
			}
		}

		public bool Localizable {
			get {
				return _Localizable;
			}
			set {
				this._Localizable = value;
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

	public interface Interface_Text
	{
		int FontSize {
			get;
			set;
		}
	}
}
