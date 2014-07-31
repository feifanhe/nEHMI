using System.ComponentModel;
using System.Collections.Generic;

using BasicAttributes.Helper;

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

		//public struct Key
		//{
		//    public readonly int Value;
		//    public readonly string Password;
		//    public Key(int Value, string Password) {
		//        this.Value = Value;
		//        this.Password = Password;
		//    }
		//    // Equals and GetHashCode ommitted
		//}

		[TypeConverter( typeof( ItemConverter ) )]
		internal class PWDActions
		{
			// Constructor used to compensate Collection attribute limitation.
			public PWDActions(string DummyInput) {
			}

			private List<string> _Correct = new List<string>();
			[Description("Action to do when password is CORRECT.")]
			public List<string> Correct {
				get {
					return _Correct;
				}
				set {
					_Correct = value;
				}
			}

			private List<string> _Wrong = new List<string>();
			[Description("Action to do when password is WRONG.")]
			public List<string> Wrong {
				get {
					return _Wrong;
				}
				set {
					_Wrong = value;
				}
			}

			private string _Password = string.Empty;
			public string Password {
				get {
					return _Password;
				}
				set {
					_Password = value;
				}
			}

			public override string ToString( ) {
				return string.Empty;
			}
		}

		private Collection _ActionsPWD = new Collection(typeof(PWDActions));
		[Description( "Actions that will need password to execute." )]
		public Collection ActionsPWD {
			get {
				return _ActionsPWD;
			}
			set {
				_ActionsPWD = value;
			}
		}

		public override string ToString( ) {
			return string.Empty;
		}
	}
}
