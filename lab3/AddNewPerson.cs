using System;
using System.Windows.Forms;

namespace lab3
{
    public partial class AddNewPerson : Form
    {
        public static Person newPerson { get; set; }

        public AddNewPerson()
        {
            InitializeComponent();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            newPerson = new Person(name_txb.Text, surname_txb.Text,
                birthdate_txb.Text, residence_txb.Text);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
