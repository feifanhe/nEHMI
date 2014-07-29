using System.ComponentModel;

using BasicAttributes.Attributes;
using System.Collections.Generic;

namespace StockComponents
{
	public class MultiPicture
	{
		private Collection _Items = new Collection();
		[TypeConverter(typeof(ExpandableObjectConverter))]
		public Collection Items {
			get {
				return _Items;
			}
		}

		//private List<Picture> _template = new List<Picture>();
		//public List<Picture> template {
		//    get {
		//        return _template;
		//    }
		//}
	}
}
