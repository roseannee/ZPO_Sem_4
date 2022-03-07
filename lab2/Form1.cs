using System;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        Operation operation;

        public Form1()
        {
            InitializeComponent();
        }

        delegate double Operation(double x);

        double Square(double x) => Math.Pow(x, 2);
        double Root(double x) => Math.Sqrt(x);
        double Inverse(double x) => 1 / x;

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

        private void calc_bt_Click(object sender, EventArgs e)
        {
            if (square_chb.Checked)
            {
                DoOperation(OperationType.Square);
            }
            else if (root_chb.Checked)
            {
                DoOperation(OperationType.Root);
            }
            else
            {
                DoOperation(OperationType.Inverse);
            }
        }

        private void DoOperation(OperationType op_type)
        {
            operation = SelectOperation(op_type);
            selected_op_lb.Text = op_type.ToString();
            res_tb.Text = operation(double.Parse(num_tb.Text)).ToString();
        }
    }
}
