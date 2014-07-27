using System.Drawing;
using System.ComponentModel;

namespace BasicAttributes.Attributes
{
	[TypeConverter( typeof( ExpandableObjectConverter ) )]
	public class Common
	{
		private string _Group = string.Empty;
		[Category( "Common" )]
		[Description( "Group of components that this one belongs to." )]
		public string Group {
			get {
				return _Group;
			}
			set {
				_Group = value;
			}
		}

		private string _Name = string.Empty;
		[Category( "Common" )]
		[Description( "Component name." )]
		public string Name {
			get {
				return _Name;
			}
			set {
				_Name = value;
			}
		}

		private Color _BorderColor = SystemColors.InactiveBorder;
		[Category( "Common" )]
		[Description( "Border color of the component." )]
		public Color BorderColor {
			get {
				return _BorderColor;
			}
			set {
				_BorderColor = value;
			}
		}

		private Color _BackgroundColor = SystemColors.Control;
		[Category( "Common" )]
		[Description( "Background color of the component." )]
		public Color BackgroundColor {
			get {
				return _BackgroundColor;
			}
			set {
				_BackgroundColor = value;
			}
		}

		private bool _Visibility = true;
		[Category( "Common" )]
		[Description( @"Visibility of the component.
						Parameter will be overridden by Visible Condition." )]
		public bool Visibility {
			get {
				return _Visibility;
			}
			set {
				_Visibility = value;
			}
		}

		private string _InvisibleCondition;
		[Category( "Common" )]
		[Description( "Describe the invisible condition." )]
		public string InvisibleCondition {
			get {
				return _InvisibleCondition;
			}
			set {
				_InvisibleCondition = value;
			}
		}

		private string _VisibleCondition;
		[Category( "Common" )]
		[Description( "Describe the visible condition." )]
		public string VisibleCondition {
			get {
				return _VisibleCondition;
			}
			set {
				_VisibleCondition = value;
			}
		}

		private string _EnableCondition;
		[Category( "Common" )]
		[Description( "Describe when to enable the component." )]
		public string EnableCondition {
			get {
				return _EnableCondition;
			}
			set {
				_EnableCondition = value;
			}
		}

		

		private Dimension _Dimension = new Dimension();
		[Category( "Common" )]
		[Description( "Set the height and width of the component." )]
		[TypeConverter( typeof( ExpandableObjectConverter ) )]
		public Dimension Dimension {
			get {
				return _Dimension;
			}
			set {
				_Dimension = value;
			}
		}
	}

	public class Dimension
	{
		private int _Height;
		private int _Width;
		public int Height {
			get {
				return _Height;
			}
			set {
				_Height = value;
			}
		}
		public int Width {
			get {
				return _Width;
			}
			set {
				_Width = value;
			}
		}
	}
}
