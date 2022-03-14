using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    internal class Validation
    {
        public static void IntValidation(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != ',' && e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
