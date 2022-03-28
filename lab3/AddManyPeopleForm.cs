using System;
using System.Windows.Forms;

namespace lab3
{
    public partial class AddManyPeopleForm : Form
    {
        public event EventHandler<Person> PersonEvent;
        public static Person person;

        public AddManyPeopleForm()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            person = new Person(name_txb.Text, surname_txb.Text, birthdate_txb.Text, residence_txb.Text);

            PersonEvent?.Invoke(this, person);

            ClearTextBoxes();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearTextBoxes()
        {
            name_txb.Text = "";
            surname_txb.Text = "";
            birthdate_txb.Text = "";
            residence_txb.Text = "";
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
