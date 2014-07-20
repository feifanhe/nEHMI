using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace BasicAttributes
{
	public interface IText
	{
		int FontSize {
			get;
			set;
		}
		Color TextColor {
			get;
			set;
		}
		bool Localizable {
			get;
			set;
		}
		Justification Alignment {
			get;
			set;
		}
	}
	
	public class Text
	{
		private int _FontSize;
		private Color _TextColor;
		private bool _Localizable;
		private Justification _Alignment;

		[Category( "Text" )]
		[Description( "Set the font size of the text displayed." )]
		[DefaultValue(12)]
		public int FontSize {
			get {
				return _FontSize;
			}
			set {
				this._FontSize = value;
			}
		}

		[Category( "Text" )]
		[Description( "Set the color of the text displayed." )]
		public Color TextColor {
			get {
				return _TextColor;
			}
			set {
				this._TextColor = value;
			}
		}

		[Category( "Text" )]
		public bool Localizable {
			get {
				return _Localizable;
			}
			set {
				this._Localizable = value;
			}
		}

		[Category( "Text" )]
		[DefaultValue(Justification.MiddleCenter)]
		public Justification Alignment {
			get {
				return _Alignment;
			}
			set {
				this._Alignment = value;
			}
		}

		public override string ToString( ) {
			return String.Empty;
		}
	}
}
