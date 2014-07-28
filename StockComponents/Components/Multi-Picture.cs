using System;
using System.Collections.Generic;
using System.Text;

namespace StockComponents
{
	public class MultiPicture
	{
		private static List<Picture> _MultiPicture = new List<Picture>();

		public List<Picture> Items {
			get {
				return _MultiPicture;
			}
			set {
				_MultiPicture = value;
			}
		}

		// Simulate List<T> behaviour
		public void Add(Picture content) {
			_MultiPicture.Add( content );
		}

		public void Remove(Picture content) {
			_MultiPicture.Remove( content );
		}

		public Picture this[ int index ] {
			get {
				return _MultiPicture[ index ];
			}
			set {
				_MultiPicture[ index ] = value;
			}
		}
	}
}
