using System.ComponentModel;

using BasicAttributes.Helper;

namespace BasicAttributes.Attributes
{
	[TypeConverter( typeof( ExpandableObjectConverter ) )]
	public class ButtonDetail
	{
		private bool _Enable = true;
		[Category("Button Detail")]
		[Description("Enable the button or not.")]
		[DefaultValue(true)]
		public bool Enable {
			get {
				return _Enable;
			}
			set {
				_Enable = value;
			}
		}

		private int _ShadowEffect = 0;
		[Category( "Button Detail" )]
		[Description( "How apparent is the shadow." )]
		[DefaultValue(0)]
		public int ShadowEffect {
			get {
				return _ShadowEffect;
			}
			set {
				_ShadowEffect = value;
			}
		}

		private bool _TriggerByEnter = false;
		[Category( "Button Detail" )]
		[Description( "Can the button trigger by ENTER key?" )]
		[DefaultValue(false)]
		public bool TriggerByEnter {
			get {
				return _TriggerByEnter;
			}
			set {
				_TriggerByEnter = value;
			}
		}

		private bool _Button3D = false;
		[Category( "Button Detail" )]
		[DisplayName("3D Button")]
		[Description( "Choose YES to enable 3D effect on the button." )]
		[DefaultValue( false )]
		[TypeConverter(typeof(YesNoDecisionConverter))]
		public bool Button3D {
			get {
				return _Button3D;
			}
			set {
				_Button3D = value;
			}
		}

		private bool _Hold = false;
		[Category( "Button Detail" )]
		[Description( "Hold after pressed?" )]
		[DefaultValue( false )]
		[TypeConverter( typeof( YesNoDecisionConverter ) )]
		public bool Hold {
			get {
				return _Hold;
			}
			set {
				_Hold = value;
			}
		}

		private ButtonShape _ButtonShape = ButtonShape.Rectangle;
		[Category( "Button Detail" )]
		[Description( "The shape of the button." )]
		[DefaultValue( ButtonShape.Rectangle )]
		public ButtonShape ButtonShape {
			get {
				return _ButtonShape;
			}
			set {
				_ButtonShape = value;
			}
		}

		public override string ToString( ) {
			return string.Empty;
		}
	}
}
