using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BasicAttributes;

namespace StockComponents
{
	class RootConverter : ExpandableObjectConverter
	{
		public override bool CanConvertTo(ITypeDescriptorContext context,
								  System.Type destinationType) {
			if( destinationType == typeof( Text ) )
				return true;

			return base.CanConvertTo( context, destinationType );
		}
	}
}
