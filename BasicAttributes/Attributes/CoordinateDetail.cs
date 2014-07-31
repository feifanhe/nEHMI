using System.ComponentModel;
using System.Drawing;

using BasicAttributes.Helper;

namespace BasicAttributes.Attributes
{
	[TypeConverter( typeof( ExpandableObjectConverter ) )]
	public class CoordinateDetail
	{
		private string _Title;
		[Category( "Coordinate Detail" )]
		[Description( "Displayed title for this component." )]
		public string Title {
			get {
				return _Title;
			}
			set {
				_Title = value;
			}
		}

		private int _ItemsPerPage;
		[Category( "Coordinate Detail" )]
		[Description( "Limit the items shown per page." )]
		public int ItemsPerPage {
			get {
				return _ItemsPerPage;
			}
			set {
				_ItemsPerPage = value;
			}
		}

		private int _Interval;
		[Category( "Coordinate Detail" )]
		[Description( "The interval between ticks." )]
		public int Interval {
			get {
				return _Interval;
			}
			set {
				_Interval = value;
			}
		}

		private Color _AxisNotAtOriginColor = Color.Red;
		[Category( "Coordinate Detail" )]
		[Description( "Color of the axis when pointer isn't at the origin." )]
		public Color AxisNotAtOriginColor {
			get {
				return _AxisNotAtOriginColor;
			}
			set {
				_AxisNotAtOriginColor = value;
			}
		}
		private Color _AxisSelectedColor = Color.Green;
		[Category( "Coordinate Detail" )]
		[Description( "Color of the selected axis." )]
		public Color AxisSelectedColor {
			get {
				return _AxisSelectedColor;
			}
			set {
				_AxisSelectedColor = value;
			}
		}

		private CoordinateValue _CoordinateValue = new CoordinateValue();
		[Category( "Coordinate Detail" )]
		[Description( "Visual settings for coordinate values." )]
		public CoordinateValue CoordinateValue {
			get {
				return _CoordinateValue;
			}
			set {
				_CoordinateValue = value;
			}
		}

		private AxisName _AxisName = new AxisName();
		[Category( "Coordinate Detail" )]
		[Description( "Visual settings for axis labels." )]
		public AxisName AxisName {
			get {
				return _AxisName;
			}
			set {
				_AxisName = value;
			}
		}

		private CoordinateType _CoordinateType = CoordinateType.Machine;
		[Category( "Coordinate Detail" )]
		[Description( "The desired coordinate type of this component." )]
		[TypeConverter( typeof( EnumDescriptionConverter ) )]
		public CoordinateType CoordinateType {
			get {
				return _CoordinateType;
			}
			set {
				_CoordinateType = value;
			}
		}

		private int _AxialGroup = 0;
		[Category( "Coordinate Detail" )]
		[Description( @"Use the data from which axial group?
						The value can only range from 0 to 10!" )]
		public int AxialGroup {
			get {
				return _AxialGroup;
			}
			set {
				_AxialGroup = value;
			}
		}

		public override string ToString( ) {
			return string.Empty;
		}
	}

	public class CoordinateValue
	{
		private Color _TextColor = SystemColors.ControlText;
		[Description( "Set the color of the coordinate values." )]
		public Color TextColor {
			get {
				return _TextColor;
			}
			set {
				_TextColor = value;
			}
		}

		private Color _BackgroundColor = SystemColors.Control;
		[Description( "Background color of the coordinate values." )]
		public Color BackgroundColor {
			get {
				return _BackgroundColor;
			}
			set {
				_BackgroundColor = value;
			}
		}

		private int _FontSize = 9;
		[Description( "Set the font size for the coordinate values." )]
		[DefaultValue( 9 )]
		public int FontSize {
			get {
				return _FontSize;
			}
			set {
				this._FontSize = value;
			}
		}

		private BorderStyle _BorderStyle = BorderStyle.WithoutBorder;
		[Description( "The visibility of the border." )]
		[DefaultValue( BorderStyle.WithoutBorder )]
		[TypeConverter( typeof( EnumDescriptionConverter ) )]
		public BorderStyle BorderStyle {
			get {
				return _BorderStyle;
			}
			set {
				_BorderStyle = value;
			}
		}
	}

	public class AxisName 
	{
		private Color _TextColor = SystemColors.ControlText;
		[Description( "Set the color of the axis labels." )]
		public Color TextColor {
			get {
				return _TextColor;
			}
			set {
				_TextColor = value;
			}
		}

		private Color _BackgroundColor = SystemColors.Control;
		[Description( "Background color of the axis labels." )]
		public Color BackgroundColor {
			get {
				return _BackgroundColor;
			}
			set {
				_BackgroundColor = value;
			}
		}

		private int _FontSize = 9;
		[Description( "Set the font size for the axis labels." )]
		[DefaultValue( 9 )]
		public int FontSize {
			get {
				return _FontSize;
			}
			set {
				this._FontSize = value;
			}
		}

		private BorderStyle _BorderStyle = BorderStyle.WithoutBorder;
		[Description( "The visibility of the border." )]
		[DefaultValue( BorderStyle.WithoutBorder )]
		[TypeConverter( typeof( EnumDescriptionConverter ) )]
		public BorderStyle BorderStyle {
			get {
				return _BorderStyle;
			}
			set {
				_BorderStyle = value;
			}
		}
	}
}
