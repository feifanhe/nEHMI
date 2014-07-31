using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;

using BasicAttributes.Helper;

namespace BasicAttributes.Attributes
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class MeterDetail
	{
		private Color _ScaleColor = Color.Black;
		[Category("Meter Detail")]
		[Description("The color of the scales.")]
		public Color ScaleColor {
			get {
				return _ScaleColor;
			}
			set {
				_ScaleColor = value;
			}
		}

		private Color _MeterColor = SystemColors.Control;
		[Category( "Meter Detail" )]
		[Description( "The color of the meter base." )]
		public Color MeterColor {
			get {
				return _MeterColor;
			}
			set {
				_MeterColor = value;
			}
		}

		private Color _ValueColor = Color.Black;
		[Category( "Meter Detail" )]
		[Description( "The color of the values." )]
		public Color ValueColor {
			get {
				return _ValueColor;
			}
			set {
				_ValueColor = value;
			}
		}

		private ValueBoundaries _LinearBoundaries = new ValueBoundaries();
		[Category( "Meter Detail" )]
		[Description( "The upper and lower boundary under linear mode." )]
		public ValueBoundaries LinearBoundaries {
			get {
				return _LinearBoundaries;
			}
			set {
				_LinearBoundaries = value;
			}
		}

		private ValueBoundaries _AngularBoundaries = new ValueBoundaries();
		[Category( "Meter Detail" )]
		[Description( "The upper and lower boundary under angular mode." )]
		public ValueBoundaries AngularBoundaries {
			get {
				return _AngularBoundaries;
			}
			set {
				_AngularBoundaries = value;
			}
		}

		private MeterStyle _Style = MeterStyle.SemiCircle;
		[Category( "Meter Detail" )]
		[Description( "Visual style of the meter." )]
		[TypeConverter(typeof(EnumDescriptionConverter))]
		public MeterStyle Style {
			get {
				return _Style;
			}
			set {
				_Style = value;
			}
		}

		private Intervals _Intervals = new Intervals();
		[Category( "Meter Detail" )]
		[Description( "The interval between major ticks and minor ticks." )]
		public Intervals Intervals {
			get {
				return _Intervals;
			}
			set {
				_Intervals = value;
			}
		}

		private Dictionary<ValueBoundaries, Color> _SectionColor = new Dictionary<ValueBoundaries, Color>();
		public Dictionary<ValueBoundaries, Color> SectionColor {
			get {
				return _SectionColor;
			}
			set {
				_SectionColor = value;
			}
		}

		public override string ToString( ) {
			return string.Empty;
		}
	}

	[TypeConverter( typeof( ExpandableObjectConverter ) )]
	public class ValueBoundaries
	{
		private int _Minimum;
		public int Minimum {
			get {
				return _Minimum;
			}
			set {
				_Minimum = value;
			}
		}

		private int _Maximum;
		public int Maximum {
			get {
				return _Maximum;
			}
			set {
				_Maximum = value;
			}
		}

		public override string ToString( ) {
			return "[ " + _Minimum.ToString() + ", " + _Maximum.ToString() + " ]";
		}
	}

	[TypeConverter( typeof( ExpandableObjectConverter ) )]
	public class Intervals
	{
		private int _Minor;
		public int Minor {
			get {
				return _Minor;
			}
			set {
				_Minor = value;
			}
		}

		private int _Major;
		public int Major {
			get {
				return _Major;
			}
			set {
				_Major = value;
			}
		}

		public override string ToString( ) {
			return string.Empty;
		}
	}
}
