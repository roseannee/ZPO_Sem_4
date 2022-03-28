using System.Windows.Forms;

namespace lab3
{
    internal class Validation
    {
        public static void CharValidation(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar)
                                && e.KeyChar != '.' && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        public static void BirthDateValidation(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

    }
}
