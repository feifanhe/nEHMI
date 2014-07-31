using System.ComponentModel;

namespace BasicAttributes.Attributes
{
	[TypeConverter( typeof( ExpandableObjectConverter ) )]
	public class InputDetail
	{
		private Format _Format;
		[Category("Input Detail")]
		[Description("The represent format of the numbers in registry.")]
		public Format Format {
			get {
				return _Format;
			}
			set {
				_Format = value;
			}
		}

		private Registry _StorageRegistry;
		[Category( "Input Detail" )]
		[Description( "The registry that will handle the input value." )]
		public Registry StorageRegistry {
			get {
				return _StorageRegistry;
			}
			set {
				_StorageRegistry = value;
			}
		}

		private string _MacroAddress;
		[Category( "Input Detail" )]
		[Description( "The address of the MACRO." )]
		public string MacroAddress {
			get {
				return _MacroAddress;
			}
			set {
				_MacroAddress = value;
			}
		}

		private bool _StoreRPermanently;
		[Category( "Input Detail" )]
		[Description( "Checked to move the designated R registry to a permanent registry." )]
		public bool StoreRPermanently {
			get {
				return _StoreRPermanently;
			}
			set {
				_StoreRPermanently = value;
			}
		}

		private Registry _PermanentRegistry;
		[Category( "Input Detail" )]
		[Description( "Permanent registry for the desired R registry." )]
		public Registry PermanentRegistry {
			get {
				return _PermanentRegistry;
			}
			set {
				_PermanentRegistry = value;
			}
		}

		private bool _AllowEmptyString;
		[Category( "Input Detail" )]
		[Description( "Checked to accept empty string from the input." )]
		public bool AllowEmptyString {
			get {
				return _AllowEmptyString;
			}
			set {
				_AllowEmptyString = value;
			}
		}

		private bool _AllowInput;
		[Category( "Input Detail" )]
		[Description( "Checked to allow user input." )]
		public bool AllowInput {
			get {
				return _AllowInput;
			}
			set {
				_AllowInput = value;
			}
		}

		private string _AllowCondition;
		[Category( "Input Detail" )]
		[Description( "Describe the condition that will allow the user to input." )]
		[TypeConverter( typeof( ExpandableObjectConverter ) )]
		public string AllowCondition {
			get {
				return _AllowCondition;
			}
			set {
				_AllowCondition = value;
			}
		}

		private InputRange _InputRange;
		[Category( "Input Detail" )]
		[Description( "Input range in metric units." )]
		[TypeConverter( typeof( ExpandableObjectConverter ) )]
		public InputRange InputRange {
			get {
				return _InputRange;
			}
			set {
				_InputRange = value;
			}
		}

		private InputRange _InputRangeInch;
		[Category( "Input Detail" )]
		[Description( "Input range in imperial units." )]
		public InputRange InputRangeInch {
			get {
				return _InputRangeInch;
			}
			set {
				_InputRangeInch = value;
			}
		}

		public override string ToString( ) {
			return string.Empty;
		}
	}

	public class InputRange
	{
		private int _Minimum = 0;
		[DefaultValue( 0 )]
		[RefreshProperties( RefreshProperties.All )]
		public int Minimum {
			get {
				return _Minimum;
			}
			set {
				_Minimum = value;
			}
		}

		private int _Maximum;
		[RefreshProperties( RefreshProperties.All )]
		public int Maximum {
			get {
				return _Maximum;
			}
			set {
				_Maximum = value;
			}
		}

		public override string ToString( ) {
			return string.Empty;
		}
	}
}
