using System.Drawing;
using System.ComponentModel;

using BasicAttributes.Details;
using BasicAttributes.Helper;

namespace BasicAttributes.Attributes
{
	public class Text
	{
		private int _FontSize = 9;
		[Category( "Text" )]
		[Description( "Set the font size of the text displayed." )]
		public int FontSize {
			get {
				return _FontSize;
			}
			set {
				this._FontSize = value;
			}
		}

		private Color _TextColor = SystemColors.ControlText;
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

		private bool _Localizable = false;
		[Category( "Text" )]
		[Description( "Checked when the text needs to have multilingual requirement." )]
		public bool Localizable {
			get {
				return _Localizable;
			}
			set {
				this._Localizable = value;
			}
		}

		private Justification _Alignment = Justification.MiddleCenter;
		[Category( "Text" )]
		[Description( "Set the alignment of the text displayed." )]
		public Justification Alignment {
			get {
				return _Alignment;
			}
			set {
				this._Alignment = value;
			}
		}

		private Multilingual _Caption = new Multilingual();
		[Category( "Text" )]
		[Description( "Text for users." )]
		public string Caption {
			get {
				if(_Localizable)
					return _Caption[this.Language];
				else
					return _Caption["Default"];
			}
			set {
				if(_Localizable)
					_Caption[this.Language] = value;
				else
				_Caption["Default"] = value;
			}
		}

		private string _Language = string.Empty;
		[Category("Text")]
		[Description("Current language of the displayed text.")]
		//[Browsable(true)]
		[TypeConverter(typeof(LanguageConverter))]
		public string Language {
			get {
				string S = "";
				if( _Language != null && _Language.Length > 0)
				{
					S = _Language;
				}
				else
				{
					S = "Default";
				}

				return S;
			}
			set {
				_Language = value;
			}
		}
	}
}
