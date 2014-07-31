using System.ComponentModel;

using BasicAttributes.Attributes;

namespace StockComponents
{
	public class DropdownMenu
	{
		private Common _Common = new Common();
		public Common Common {
			get {
				return _Common;
			}
			set {
				_Common = value;
			}
		}

		private Text _Text = new Text();
		public Text Text {
			get {
				return _Text;
			}
			set {
				_Text = value;
			}
		}

		private InputDetail _InputDetail = new InputDetail();
		public InputDetail InputDetail {
			get {
				return _InputDetail;
			}
			set {
				_InputDetail = value;
			}
		}

		[TypeConverter( typeof( ExpandableObjectConverter ) )]
		internal class DropdownMenuItem
		{
			public DropdownMenuItem(int Value) {
				this._Value = Value;
			}

			private int _Value;
			public int Value {
				get {
					return _Value;
				}
				set {
					_Value = value;
				}
			}

			private Text _Text = new Text();
			public Text Text {
				get {
					return _Text;
				}
				set {
					_Text = value;
				}
			}

			private Image _Image = new Image();
			public Image Image {
				get {
					return _Image;
				}
				set {
					_Image = value;
				}
			}

			private SelectionPack _SelectionPack = new SelectionPack();
			public SelectionPack Actions {
				get {
					return _SelectionPack;
				}
				set {
					_SelectionPack = value;
				}
			}
		}

		private Collection _Items = new Collection( typeof( DropdownMenuItem ) );
		public Collection Items {
			get {
				return _Items;
			}
			set {
				_Items = value;
			}
		}
	}
}
