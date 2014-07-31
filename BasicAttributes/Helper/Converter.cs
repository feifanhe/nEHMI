using System;
using System.ComponentModel;
using System.Reflection;

using BasicAttributes.Details;
using System.Globalization;

using BasicAttributes.Attributes;

namespace BasicAttributes.Helper
{
	internal class LanguageConverter : StringConverter
	{
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context) {
			//true means show a combobox
			return true;
		}

		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) {
			//true will limit to list. false will show the list, but allow free-form entry
			return true;
		}

		public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) {
			return new StandardValuesCollection( Multilingual.GetCultures );
		}
	}

	internal class EnumDescriptionConverter : EnumConverter
	{
		private Type _enumType;

		public EnumDescriptionConverter(Type type)
			: base( type ) {
			_enumType = type;
		}

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destType) {
			return destType == typeof( string );
		}

		public override object ConvertTo(ITypeDescriptorContext context,
											CultureInfo culture,
											object value,
											Type destType) {
			FieldInfo fi = _enumType.GetField( Enum.GetName( _enumType, value ) );
			DescriptionAttribute da = (DescriptionAttribute)Attribute.GetCustomAttribute( fi, typeof( DescriptionAttribute ) );

			if( da != null )
				return da.Description;
			else
				return value.ToString();
		}

		public override bool CanConvertFrom(ITypeDescriptorContext context, Type srcType) {
			return srcType == typeof( string );
		}

		public override object ConvertFrom(ITypeDescriptorContext context,
											CultureInfo culture,
											object value) {
			foreach( FieldInfo fi in _enumType.GetFields() )
			{
				DescriptionAttribute da = (DescriptionAttribute)Attribute.GetCustomAttribute( fi, typeof( DescriptionAttribute ) );

				if( ( da != null ) && ( (string)value == da.Description ) )
					return Enum.Parse( _enumType, fi.Name );
			}
			return Enum.Parse( _enumType, (string)value );
		}
	}

	internal class YesNoDecisionConverter : BooleanConverter
	{
		public override object ConvertTo(ITypeDescriptorContext context,
											CultureInfo culture,
											object value,
											Type destType) {
			return (bool)value ? "Yes" : "No";
		}

		public override object ConvertFrom(ITypeDescriptorContext context,
											CultureInfo culture,
											object value) {
			return (string)value == "Yes";
		}
	}
}
