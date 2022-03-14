using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        Operation operation;
        Appearance[] newAppearance = new Appearance[3];
        ResetAppearance[] resetAppearance = new ResetAppearance[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void calcSingle_bt_Click(object sender, EventArgs e)
        {
            if (square_chb.Checked)
            {
                DoSingleNumOperation(OperationType.Square);
            }
            else if (root_chb.Checked)
            {
                DoSingleNumOperation(OperationType.Root);
            }
            else
            {
                DoSingleNumOperation(OperationType.Inverse);
            }
        }

        private void calcArray_bt_Click(object sender, EventArgs e)
        {
            string[] str_array = num_tb.Text.Split(' ');

            double[] tempArray = new double[str_array.Length];
            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = double.Parse(str_array[i]);
            }

            double[] dbl_array;

            if (square_chb.Checked)
            {
                res_tb.Text = "";

                dbl_array = ArrayOperation(tempArray, Square);
                selected_op_lb.Text = "Square";
                PrintArray(dbl_array);
            }
            else if (root_chb.Checked)
            {
                res_tb.Text = "";

                dbl_array = ArrayOperation(tempArray, Root);
                selected_op_lb.Text = "Root";
                PrintArray(dbl_array);
            }
            else
            {
                res_tb.Text = "";

                dbl_array = ArrayOperation(tempArray, Inverse);
                selected_op_lb.Text = "Inverse";
                PrintArray(dbl_array);
            }
        }

        private void applyAppearanceChanges_bt_Click(object sender, EventArgs e)
        {
            FillAppearanceDelegate();

            if (changeBgColor_chb.Checked)
            {
                newAppearance[0]();
            }
            else
            {
                resetAppearance[0]();
            }

            if (changeFontColor_chb.Checked)
            {
                newAppearance[1]();
            }
            else
            {
                resetAppearance[1]();
            }

            if (changeFontStyle_chb.Checked)
            {
                newAppearance[2]();
            }
            else
            {
                resetAppearance[2]();
            }
        }

        public delegate double Operation(double x);
        private double Square(double x) => Math.Pow(x, 2);
        private double Root(double x) => Math.Sqrt(x);
        private double Inverse(double x) => 1 / x;

        enum OperationType
        {
            Square, Root, Inverse
        }

        Operation SelectOperation(OperationType type)
        {
            switch (type)
            {
                case OperationType.Square:
                    return Square;
                case OperationType.Root:
                    return Root;
                case OperationType.Inverse:
                    return Inverse;
                default:
                    return Square;
            }
        }

        private void DoSingleNumOperation(OperationType op_type)
        {
            operation = SelectOperation(op_type);
            selected_op_lb.Text = op_type.ToString();
            res_tb.Text = operation(double.Parse(num_tb.Text)).ToString();
        }

        private double[] ArrayOperation(double[] array, Operation operation)
        {
            double[] resArray = new double[array.Length];

            for (int i = 0; i < resArray.Length; i++)
            {
                resArray[i] = operation(array[i]);
            }

            return resArray;
        }

        private void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                res_tb.Text += array[i] + " ";
            }
        }

        public delegate void Appearance();
        private void ChangeBgColor() => BackColor = SystemColors.GradientInactiveCaption;
        private void ChangeFontColor()
        {
            num_tb.ForeColor = Color.Green;
            res_tb.ForeColor = Color.DarkViolet;
        }
        private void ChangeFontStyle() 
        {
            num_tb.Font = new Font("Century Gothic", 9.75f, FontStyle.Bold);
            res_tb.Font = new Font("Century Gothic", 9.75f, FontStyle.Bold);
        } 

        public delegate void ResetAppearance();
        private void ResetBgColor() => BackColor = SystemColors.Control;
        private void ResetFontColor()
        {
            num_tb.ForeColor = SystemColors.WindowText;
            res_tb.ForeColor = SystemColors.WindowText;
        }
        private void ResetFontStyle()
        {
            num_tb.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular);
            res_tb.Font = new Font("Century Gothic", 9.75f, FontStyle.Regular);
        }

        private void FillAppearanceDelegate()
        {
            newAppearance[0] = ChangeBgColor;
            newAppearance[1] = ChangeFontColor;
            newAppearance[2] = ChangeFontStyle;

            resetAppearance[0] = ResetBgColor;
            resetAppearance[1] = ResetFontColor;
            resetAppearance[2] = ResetFontStyle;
        }

        private void Chb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox tmp = (CheckBox)sender;

            foreach (CheckBox c in groupBox1.Controls)
            {
                c.CheckedChanged -= Chb_CheckedChanged;
                c.Checked = false;
            }

            tmp.Checked = true;

            foreach (CheckBox c in groupBox1.Controls)
            {
                c.CheckedChanged += Chb_CheckedChanged;
            }
        }

        private void onlyNumbersValidation(object sender, KeyPressEventArgs e)
        {
            Validation.IntValidation(e);
        }
    }
}
