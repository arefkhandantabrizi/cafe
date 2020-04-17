using System.Windows.Forms;

namespace HomeCafe.My_Custom_Classes
{
    public interface IInputValidation
    {
        void LetterOnly(KeyPressEventArgs e);
        void DigitOnly(KeyPressEventArgs e);
    }
}