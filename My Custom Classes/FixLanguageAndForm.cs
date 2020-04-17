using System.Windows.Forms;

namespace HomeCafe.My_Custom_Classes
{
    public class FixLanguageAndForm : IFixLanguageAndForms
    {
        private InputLanguage _original;

        public void FixLanguage()
        {
            _original = InputLanguage.CurrentInputLanguage;
            var culture = System.Globalization.CultureInfo.GetCultureInfo("fa-IR");
            var language = InputLanguage.FromCulture(culture);
            InputLanguage.CurrentInputLanguage = language != null && InputLanguage.InstalledInputLanguages.IndexOf(language) >= 0 ? language : InputLanguage.DefaultInputLanguage;
        }

        public void OriginalLanguage()
        {
            InputLanguage.CurrentInputLanguage = _original;
        }
    }
}