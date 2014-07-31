using System.Collections.Generic;
using System.ComponentModel;

namespace BasicAttributes.Attributes
{
	[TypeConverter( typeof( ExpandableObjectConverter ) )]
	//TODO: Custome UI Editor here
	public class Advance
	{
		private List<string> _OnFinishEditing = new List<string>();
		[Category("Advance")]
		[Description("Actions execute when edit upon the component is finished.")]
		[DisplayName("On Finish Editing")]
		public List<string> OnFinishEditing {
			get {
				return _OnFinishEditing;
			}
			set {
				_OnFinishEditing = value;
			}
		}

		private List<string> _OnFocus = new List<string>();
		[Category( "Advance" )]
		[Description("Actions execute when the component gain focus.")]
		[DisplayName("On Focus")]
		public List<string> OnFocus {
			get {
				return _OnFocus;
			}
			set {
				_OnFocus = value;
			}
		}

		private List<string> _LooseFocus = new List<string>();
		[Category( "Advance" )]
		[Description( "Actions execute when the component loose focus." )]
		[DisplayName("Loose Focus")]
		public List<string> LooseFocus {
			get {
				return _LooseFocus;
			}
			set {
				_LooseFocus = value;
			}
		}

		public override string ToString( ) {
			return string.Empty;
		}
	}
}
