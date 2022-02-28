using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        static Dictionary<int, int> circles = new Dictionary<int, int>();
        static Dictionary<int, int> rectangles = new Dictionary<int, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    circles.Add(e.X, e.Y);

                    mouseButtons.Text = MouseButtons.Left.ToString();

                    panel.Refresh();
                }
                else if (e.Button == MouseButtons.Right)
                {
                    rectangles.Add(e.X, e.Y);

                    mouseButtons.Text = MouseButtons.Right.ToString();

                    panel.Refresh();
                }
                else
                {
                    mouseButtons.Text = MouseButtons.Middle.ToString();
                }
            }
            catch { }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel.CreateGraphics();

            foreach (var circle in circles)
            {
                g.FillEllipse(Brushes.Blue, circle.Key - 25, circle.Value - 25, 50, 50);
            }

            foreach (var rectangle in rectangles)
            {
                g.FillRectangle(Brushes.Red, rectangle.Key - 25, rectangle.Value - 25, 50, 50);
            }
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            coordinates.Text = $"X: {e.X}; Y: {e.Y}";
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            panel.Cursor = Cursors.Cross;
        }
    }
}
