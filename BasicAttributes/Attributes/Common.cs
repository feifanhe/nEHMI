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
		[DefaultValue( true )]
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

		private Size _Size = new Size();
		[Category( "Common" )]
		[Description( "The size of component in pixels." )]
		[TypeConverter( typeof( ExpandableObjectConverter ) )]
		public Size Dimension {
			get {
				return _Size;
			}
			set {
				_Size = value;
			}
		}

		private Location _Location = new Location();
		[Category( "Common" )]
		[Description( "Position of the top-left corner of the component with respect to the entire view." )]
		[TypeConverter( typeof( ExpandableObjectConverter ) )]
		public Location Position {
			get {
				return _Location;
			}
			set {
				_Location = value;
			}
		}

		public override string ToString( ) {
			return string.Empty;
		}
	}

	public class Size
	{
		private int _Height = 0;
		[DefaultValue( 0 )]
		[RefreshProperties( RefreshProperties.All )]
		public int Height {
			get {
				return _Height;
			}
			set {
				_Height = value;
			}
		}

		private int _Width = 0;
		[DefaultValue( 0 )]
		[RefreshProperties( RefreshProperties.All )]
		public int Width {
			get {
				return _Width;
			}
			set {
				_Width = value;
			}
		}

		public override string ToString( ) {
			return _Height.ToString() + ", " + _Width.ToString();
		}
	}

	public class Location
	{
		private int _X = 0;
		[DefaultValue( 0 )]
		[RefreshProperties( RefreshProperties.All )]
		public int X {
			get {
				return _X;
			}
			set {
				_X = value;
			}
		}

		private int _Y = 0;
		[DefaultValue( 0 )]
		[RefreshProperties( RefreshProperties.All )]
		public int Y {
			get {
				return _Y;
			}
			set {
				_Y = value;
			}
		}

		private bool _Lock = false;
		[Category( "Common" )]
		[Description( "Lock the component to avoid relative movements between components." )]
		[DefaultValue( false )]
		public bool Lock {
			get {
				return _Lock;
			}
			set {
				_Lock = value;
			}
		}

		public override string ToString( ) {
			return _X.ToString() + ", " + _Y.ToString();
		}
	}
}
