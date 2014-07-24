using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAttributes.Details
{
	public class Multilingual
	{
		private Dictionary<string, string> values = new Dictionary<string, string>();

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
	}
}