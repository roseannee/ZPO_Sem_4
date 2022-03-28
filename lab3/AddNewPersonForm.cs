using System;
using System.Windows.Forms;

namespace lab3
{
    public partial class AddNewPersonForm : Form
    {
        public static Person newPerson;

        public AddNewPersonForm(bool isEdition, ListBox people)
        {
            InitializeComponent();

            if (isEdition)
            {
                Text = "Edit person";
                ok_btn.Text = "Edit";

                int index = people.SelectedIndex;
                string[] selectedPersonInfo = people.Items[index].ToString()
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                name_txb.Text = selectedPersonInfo[0];
                surname_txb.Text = selectedPersonInfo[1];
                birthdate_txb.Text = selectedPersonInfo[2];
                residence_txb.Text = selectedPersonInfo[3];
            }
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            newPerson = new Person(name_txb.Text, surname_txb.Text, birthdate_txb.Text, residence_txb.Text);

            DialogResult = DialogResult.OK;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OnlyCharsValidation(object sender, KeyPressEventArgs e)
        {
            Validation.CharValidation(e);
        }

        private void BirthDateValidation(object sender, KeyPressEventArgs e)
        {
            Validation.BirthDateValidation(e);
        }
    }
}