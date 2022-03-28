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
            AddNewPersonForm addPerson = new AddNewPersonForm(false, people_lbx);

            var result = addPerson.ShowDialog();
            if (result == DialogResult.OK)
            {
                people_lbx.Items.Add(AddNewPersonForm.newPerson);
            }
        }

        private void addMany_btn_Click(object sender, EventArgs e)
        {
            AddManyPeopleForm addPeople = new AddManyPeopleForm();
            addPeople.PersonEvent += PersonEvent_Add;

            addPeople.Show();
        }

        private void PersonEvent_Add(object sender, Person p)
        {
            people_lbx.Items.Add(p.ToString());
        }

        private void editSelected_btn_Click(object sender, EventArgs e)
        {
            if (people_lbx.SelectedItem != null)
            {
                AddNewPersonForm addPerson = new AddNewPersonForm(true, people_lbx);

                var result = addPerson.ShowDialog();
                if (result == DialogResult.OK)
                {
                    people_lbx.Items[people_lbx.SelectedIndex] = AddNewPersonForm.newPerson;
                }
            }
            else
            {
                MessageBox.Show("No person selected!");
            }
        }
    }
}
