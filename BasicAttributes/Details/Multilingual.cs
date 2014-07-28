using System;
using System.Globalization;
using System.Collections.Generic;

namespace BasicAttributes.Details
{
	public class Multilingual
	{
		private static Dictionary<string, string> _Values = new Dictionary<string, string>();

		public Multilingual( ) {
			//_Values.Add( "Default", string.Empty );
		}

		public Dictionary<string, string> Values {
			get {
				return _Values;
			}
			set {
				_Values = value;
			}
		}

		public string this[ string culture ] {
			get {
				if( _Values.ContainsKey( culture ) )
				{
					return _Values[ culture ];
				}
				return string.Empty;
			}
			set {
				string newVal = value;
				if( value == string.Empty )
					return;
				if( _Values.ContainsKey( culture ) )
				{
					_Values[ culture ] = newVal;
				}
				else
				{
					_Values.Add( culture, newVal );
				}

				Console.WriteLine( "* SET " + culture + " AS " + newVal + " *");
			}
		}

		private static string[] _Cultures;
		// Limit the availiability of cultures here.
		public static string[] GetCultures {
			get {
				CultureInfo[] _CultureInfo = CultureInfo.GetCultures( CultureTypes.SpecificCultures );
				_Cultures = new string[ _CultureInfo.Length + 1 ];

				for( int i = 0; i < _CultureInfo.Length; i++ )
				{
					string Language = _CultureInfo[ i ].DisplayName;
					string Contents = string.Empty;
					if( _Values.ContainsKey( Language ) )
						Contents = " = " + _Values[ Language ];
					_Cultures[ i ] = Language;// +Contents;
				}

				_Cultures[ _CultureInfo.Length ] = "Default";

				return _Cultures;
			}
		}
	}
}