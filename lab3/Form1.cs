using System;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addPerson_btn_Click(object sender, EventArgs e)
        {
            AddNewPerson addPerson = new AddNewPerson();

            var result = addPerson.ShowDialog();

            if (result == DialogResult.OK)
            {
                people_lbx.Items.Add(AddNewPerson.newPerson);
            }
        }

        private void addMany_btn_Click(object sender, EventArgs e)
        {
            AddNewPerson addPeson = new AddNewPerson();

            addPeson.Show();
        }
    }
}
