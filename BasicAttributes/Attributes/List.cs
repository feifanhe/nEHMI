using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace BasicAttributes.Attributes
{
	public class List
	{
		private List<object> _Items;// = new List<object>();

		public List(Type ContentType) {
			_Items = new List<ContentType>();
		}
		
		private Registry _SelectionRegistry = new Registry();
		[Category( "List" )]
		[Description( "Registry that points toward the selected item." )]
		public Registry SelectionRegistry {
			get {
				return _SelectionRegistry;
			}
			set {
				_SelectionRegistry = value;
			}
		}

		public void Add(object content) {
			_Items.Add( content );
		}

		public void Remove(object content) {
			_Items.Remove( content );
		}

		public object this[ int index ] {
			get {
				return _Items[ index ];
			}
			set {
				_Items[ index ] = value;
			}
		}
	}
}
