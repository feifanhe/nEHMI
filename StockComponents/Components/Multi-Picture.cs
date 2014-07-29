using System.ComponentModel;

using BasicAttributes.Attributes;
using BasicAttributes;

namespace StockComponents
{
	public class MultiPicture
	{
		private Collection _Items = new Collection();
		[Category("Multi-Picture")]
		[Description("Expand the list to show all the items.")]
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public Collection Items {
			get {
				return _Items;
			}
		}

		private Registry _Registry = new Registry();
		[Category( "Multi-Picture" )]
		[Description( "Registry that claims which item is selected." )]
		public Registry Registry {
			get {
				return _Registry;
			}
			set {
				_Registry = value;
			}
		}
	}
}
