using System.ComponentModel;

using BasicAttributes.Details;

namespace BasicAttributes.Helper
{
	public class LanguageConverter : StringConverter
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
}
