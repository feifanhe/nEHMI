using System;
using System.Collections.Generic;
using System.Text;

using BasicAttributes.Attributes;

namespace StockComponents
{
	public class Panel
	{
		private Common _Common = new Common();
		public Common Common {
			get {
				return _Common;
			}
		}
	}
}
