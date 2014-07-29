using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAttributes
{
	public class Registry
	{
		private Scope _Scope;
		private MemoryType _MemoryType;
		private int _Address;
		private int _Bit;

		public override string ToString( ) {
			return FullAddress;
		}

		public string FullAddress {
			get {
				return string.Empty;
				//if( _MemoryType.IsBitOperable )
				//    return _MemoryType.ToString() + _Address.ToString() + ( _Bit.ToString() ?? string.Empty );
				//else
				//    return _MemoryType.ToString() + _Address.ToString();
			}
			set {
				//TODO: setter for full address
			}
		}

		public MemoryType MemoryType {
			get {
				return _MemoryType;
			}
			set {
				_MemoryType = value;
			}
		}

		public int Address {
			get {
				return _Address;
			}
			set {
				_Address = value;
			}
		}

		public int Bit {
			get {
				return _Bit;
			}
			set {
				_Bit = value;
			}
		}
	}
}
