using System.ComponentModel;

namespace BasicAttributes
{
	[TypeConverter( typeof( ExpandableObjectConverter ) )]
	public class Registry
	{
		private Scope _Scope;
		private MemoryType _MemoryType;
		private string _Address = string.Empty;
		private string _Bit = string.Empty;

		public override string ToString( ) {
			return FullAddress;
		}

		private string FullAddress { // TODO: for TypeConverter
			get {
				// Parameter not settled
				if( _Address == string.Empty )
					return _Address;

				return _MemoryType.ToString() + _Address + ( ( _MemoryType.IsBitOperable ) ? ( "." + _Bit ) : string.Empty );
			}
			set {
				_MemoryType = (MemoryType)(value.ToCharArray()[ 0 ].ToString());

				string[] SplitNumericAddress = value.Substring(1).Split( '.');
				_Address = SplitNumericAddress[ 0 ];
				_Bit = SplitNumericAddress[ 1 ];
			}
		}

		public string MemoryType {
			get {
				if( _MemoryType == null )
					return string.Empty;
				return _MemoryType.ToString();
			}
			set {
				_MemoryType = (MemoryType)value;
			}
		}

		public string Address {
			get {
				return _Address;
			}
			set {
				_Address = value;
			}
		}

		public string Bit {
			get {
				return _Bit;
			}
			set {
				_Bit = value;
			}
		}
	}
}
