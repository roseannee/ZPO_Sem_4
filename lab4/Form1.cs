using System;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        Func<double, double, double> power = (double x, double n) =>
        {
            double res = 1;

            for (int i = 0; i < n; i++)
            {
                res *= x;
            }

            return res;
        };

        Func<char, int, string> createString = (char ch, int n) =>
        {
            string res = "";

            for (int i = 0; i < n; i++)
            {
                res += ch;
            }

            return res;
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void p_1_btn_Click(object sender, EventArgs e)
        {
            result_txb.Text = power(double.Parse(xn_x_txb.Text), double.Parse(xn_n_txb.Text)).ToString();
        }

        private void createString_btn_Click(object sender, EventArgs e)
        {
            result_txb.Text = createString(char.Parse(chn_char_txb.Text), int.Parse(chn_n_txb.Text));
        }
    }
}
