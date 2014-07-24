using System;
using System.Globalization;
using System.Collections.Generic;

namespace BasicAttributes.Details
{
	public class Multilingual
	{
		private Dictionary<string, string> values = new Dictionary<string, string>();

		public Multilingual( ) {
			values.Add( "Default", string.Empty );
		}

		public Dictionary<string, string> Values {
			get {
				return values;
			}
			set {
				values = value;
			}
		}

		public string this[ string culture ] {
			get {
				string result = string.Empty;
				if( values.ContainsKey( culture ) )
				{
					result = values[ culture ];
				}
				return result;
			}
			set {
				string newVal = value;
				if( values.ContainsKey( culture ) )
				{
					values[ culture ] = newVal;
				}
				else
				{
					values.Add( culture, newVal );
				}
			}
		}

		private static string[] _Cultures;
		// Limit the availiability of cultures here.
		public static string[] GetCultures {
			get {
				CultureInfo[] _CultureInfo = CultureInfo.GetCultures( CultureTypes.SpecificCultures );
				_Cultures = new string[ _CultureInfo.Length ];

				for( int i = 0; i < _CultureInfo.Length; i++ )
					_Cultures[ i ] = _CultureInfo[ i ].DisplayName;
				return _Cultures;
			}
		}
	}
}