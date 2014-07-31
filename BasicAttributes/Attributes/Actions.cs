using System.ComponentModel;
using System.Collections.Generic;

namespace BasicAttributes.Attributes
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Actions
	{
		private SelectionPack _Selected = new SelectionPack();
		[Category( "Actions" )]
		[Description( "What will the button do when it's selected?" )]
		public SelectionPack Selected {
			get {
				return _Selected;
			}
			set {
				_Selected = value;
			}
		}

		private SelectionPack _Deselected = new SelectionPack();
		[Category("Actions")]
		[Description("What will the button do when it's deselected?")]
		public SelectionPack Deselected {
			get {
				return _Deselected;
			}
			set {
				_Deselected = value;
			}
		}

		public override string ToString( ) {
			return string.Empty;
		}
	}

	[TypeConverter( typeof( ExpandableObjectConverter ) )]
	public class SelectionPack
	{
		private Registry _Registry = new Registry();
		[Description("Write into registry when action performed.")]
		public Registry Registry {
			get {
				return _Registry;
			}
			set {
				_Registry = value;
			}
		}

		private List<string> _Actions = new List<string>();
		[Description( "Actions that will execute when the action performed." )]
		public List<string> Actions {
			get {
				return _Actions;
			}
			set {
				_Actions = value;
			}
		}

		public override string ToString( ) {
			return string.Empty;
		}
	}
}
