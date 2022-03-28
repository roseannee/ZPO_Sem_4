using System;
using System.Linq;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xn_var_1_btn_Click(object sender, EventArgs e)
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

            result_txb.Text = power(double.Parse(xn_x_txb.Text), double.Parse(xn_n_txb.Text)).ToString();
        }

        private void xn_var_2_btn_Click(object sender, EventArgs e)
        {
            Func<double, double, double> power = Power();

            result_txb.Text = power(double.Parse(xn_x_txb.Text), double.Parse(xn_n_txb.Text)).ToString();
        }

        private void createString_btn_Click(object sender, EventArgs e)
        {
            Func<char, int, string> createString = (char ch, int n) =>
            {
                string res = "";

                for (int i = 0; i < n; i++)
                {
                    res += ch;
                }

                return res;
            };

            result_txb.Text = createString(char.Parse(chn_char_txb.Text), int.Parse(chn_n_txb.Text));
        }

        Func<double, double, double> Power()
        {
            return (double x, double n) =>
            {
                double res = Math.Pow(x, n);

                return res;
            };
        }

        private void sort_asc_btn_Click(object sender, EventArgs e)
        {
            int[] array = GetArray();

            Array.Sort(array, (a, b) => a - b);

            PrintArray(array);
        }

        private void sort_desc_btn_Click(object sender, EventArgs e)
        {
            int[] array = GetArray();

            Array.Sort(array, (a, b) => b - a);

            PrintArray(array);
        }

        private void sort_delegate_btn_Click(object sender, EventArgs e)
        {
            int[] array = GetArray();

            Array.Sort(array, delegate (int a, int b)
            {
                return a.CompareTo(b);
            });

            PrintArray(array);
        }

        private int[] GetArray()
        {
            string[] strArray = sort_num_txb.Text.Split(' ');
            int[] intArray = Array.ConvertAll(strArray, int.Parse);

            return intArray;
        }

        private void PrintArray(int[] array)
        {
            result_txb.Text = "";
            foreach (var item in array)
            {
                result_txb.Text += $"{item} ";
            }
        }

        private void regChg_btn_Click(object sender, EventArgs e)
        {
            resultStr_txb.Text = originalStr_txb.Text.RegisterChange();
        }

        private void delVowels_btn_Click(object sender, EventArgs e)
        {
            resultStr_txb.Text = originalStr_txb.Text.DeleteVowels();
        }

        private void wordsLen_btn_Click(object sender, EventArgs e)
        {
            resultStr_txb.Text = string.Join(" | ", originalStr_txb.Text.WordsLength());
        }

        private void isSentence_btn_Click(object sender, EventArgs e)
        {
            resultStr_txb.Text = originalStr_txb.Text.IsSentence().ToString();
        }

        private void mostFrequentElem_btn_Click(object sender, EventArgs e)
        {
            var modes = originalStr_txb.Text.Mode().ToArray();

            resultStr_txb.Text = "";
            for (int i = 0; i < modes.Length; i++)
            {
                resultStr_txb.Text += $"{modes[i]} ";
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            xn_x_txb.Text = "";
            xn_n_txb.Text = "";
            chn_char_txb.Text = "";
            chn_n_txb.Text = "";
            sort_num_txb.Text = "";
            result_txb.Text = "";

            originalStr_txb.Text = "";
            resultStr_txb.Text = "";
        }

        private void onlyNumbersValidation(object sender, KeyPressEventArgs e)
        {
            Validation.IntValidation(e);
        }

        private void onlyCharsValidation(object sender, KeyPressEventArgs e)
        {
            Validation.CharValidation(e);
        }
    }
}
