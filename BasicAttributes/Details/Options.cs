using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

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

	public enum AssistancType
	{
		Label,
		Tag
	}

	public enum Format
	{
		[Description( "Long" )]
		LNG,

		[Description( "Long:1F" )]
		LNG_1F,
		[Description( "Long:2F" )]
		LNG_2F,
		[Description( "Long:3F" )]
		LNG_3F,

		[Description( "Long:1H" )]
		LNG_1H,
		[Description( "Long:2H" )]
		LNG_2H,
		[Description( "Long:3H" )]
		LNG_3H,

		[Description( "Long:L" )]
		LNG_L,
		[Description( "Long:R" )]
		LNG_R,
		[Description( "Long:TL" )]
		LNG_TL,
		[Description( "Long:IL" )]
		LNG_IL,

		[Description( "Double" )]
		DBL,

		[Description( "Double:2F" )]
		DBL_2F,
		[Description( "Double:3F" )]
		DBL_3F,

		[Description( "Double:L" )]
		DBL_L,
		[Description( "Double:R" )]
		DBL_R,
		[Description( "Double:TL" )]
		DBL_TL,
		[Description( "Double:IL" )]
		DBL_IL,

		[Description( "String" )]
		STR,

		[Description( "1F" )]
		F_1,
		[Description( "2F" )]
		F_2,
		[Description( "3F" )]
		F_3
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

		// Type mapping for reverse lookup
		private static readonly Dictionary<string, MemoryType> instance = new Dictionary<string, MemoryType>();

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

			instance[ Type ] = this;
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

		//TODO: problems here, type initialize failed
		public static explicit operator MemoryType(string str) {
			Console.WriteLine( "* START EXPLICIT TYPE CONVERSION *" );
			MemoryType result;
			if( instance.TryGetValue( str, out result ) )
				return result;
			else
				throw new InvalidCastException();
		}
	}

	public static class Enum<T>
	{
		public static string Description(T value) {
			DescriptionAttribute[] da = (DescriptionAttribute[])( typeof( T ).GetField( value.ToString() )
																			  .GetCustomAttributes( typeof( DescriptionAttribute ), false ) );
			return da.Length > 0 ? da[ 0 ].Description : value.ToString();
		}
	}
}
