using System;
using System.Collections.Generic;
using System.Text;

namespace BasicAttributes
{
	public enum Justification
	{
		TopLeft,
		TopCenter,
		TopRight,
		MiddleLeft,
		MiddleCenter,
		MiddleRight,
		BottomLeft,
		BottomCenter,
		BottomRight
	}

	public enum BorderStyle
	{
		WithBorder,
		WithoutBorder
	}

	public enum Scope
	{
		General,
		Conditional
	}

	public sealed class MemoryType
	{

		private readonly String _Type;
		private readonly Scope _Scope;
		private readonly bool _BitOperable;

		// R P @ # L D K I O C S A
		public static readonly MemoryType R = new MemoryType( "R", Scope.Conditional, true );
		public static readonly MemoryType P = new MemoryType( "P", Scope.Conditional, true );
		public static readonly MemoryType AT = new MemoryType( "@", Scope.Conditional, true );
		public static readonly MemoryType SHARP = new MemoryType( "#", Scope.General, true );
		public static readonly MemoryType L = new MemoryType( "L", Scope.Conditional, true );
		public static readonly MemoryType D = new MemoryType( "D", Scope.General, true );
		public static readonly MemoryType K = new MemoryType( "K", Scope.General, true );
		public static readonly MemoryType I = new MemoryType( "I", Scope.General, true );
		public static readonly MemoryType O = new MemoryType( "O", Scope.General, true );
		public static readonly MemoryType C = new MemoryType( "C", Scope.General, true );
		public static readonly MemoryType S = new MemoryType( "S", Scope.General, true );
		public static readonly MemoryType A = new MemoryType( "A", Scope.General, true );

		private MemoryType(string Type, Scope Scope, bool BitOperable) {
			this._Type = Type;
			this._Scope = Scope;
			this._BitOperable = BitOperable;
		}

		public override String ToString( ) {
			return _Type;
		}

		public Scope GetScope( ) {
			return _Scope;
		}

		public bool IsBitOperable {
			get {
				return _BitOperable;
			}
		}
	}
}
