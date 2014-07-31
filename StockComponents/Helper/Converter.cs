using System;
using System.ComponentModel;
using System.Globalization;

namespace StockComponents.Helper
{
	internal class ItemConverter : ExpandableObjectConverter
	{
		public override object ConvertTo(ITypeDescriptorContext context,
											CultureInfo culture,
											object value,
											Type destType) {
			//TODO: Not the best approach here
			if( destType == typeof( string ) && value is Picture )
			{
				Picture item = (Picture)value;
				return item.Common.Name;
			}
			if( destType == typeof( string ) && value is Label )
			{
				Label item = (Label)value;
				return item.Common.Name;
			}
			return base.ConvertTo( context, culture, value, destType );
		}
	}
}
