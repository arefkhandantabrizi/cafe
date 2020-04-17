using System.Windows.Forms;

namespace HomeCafe.My_Custom_Classes
{
    public class InputValidation : IInputValidation
    {
        public void LetterOnly(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || !(char.IsDigit(e.KeyChar))
                  && e.KeyChar != '.' && e.KeyChar != '+' && e.KeyChar != '-'
                  && e.KeyChar != '(' && e.KeyChar != ')' && e.KeyChar != '*'
                  && e.KeyChar != '/' && e.KeyChar != '!' && e.KeyChar != '@'
                  && e.KeyChar != '#' && e.KeyChar != '$' && e.KeyChar != '%'
                  && e.KeyChar != '^' && e.KeyChar != '&' && e.KeyChar != '_'
                  && e.KeyChar != '|' && e.KeyChar != '?' && e.KeyChar != '>'
                  && e.KeyChar != '<' && e.KeyChar != '{' && e.KeyChar != '}'
                  && e.KeyChar != '[' && e.KeyChar != ']' && e.KeyChar != '`'
                  && e.KeyChar != '~' && e.KeyChar != ':' && e.KeyChar != ';'
                  && e.KeyChar != ':' && e.KeyChar != '؟' && e.KeyChar != '»'
                  && e.KeyChar != '«' && e.KeyChar != ':' && e.KeyChar != '"'
                  && e.KeyChar != '<' && e.KeyChar != '>' && e.KeyChar != '|'
                  && e.KeyChar != '}' && e.KeyChar != '{' && e.KeyChar != '×'
                  && e.KeyChar != '÷' && e.KeyChar != 'ـ' && e.KeyChar != '،'
                  && e.KeyChar != '؛' && e.KeyChar != '=' && e.KeyChar != '='
                  && e.KeyChar != ',' && e.KeyChar != '_'
                  && e.KeyChar != '"'))
                e.Handled = true;
        }

        public void DigitOnly(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
    }
}