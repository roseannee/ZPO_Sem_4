using System;
using System.Collections.Generic;
using System.Windows;

namespace lab7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Person> people = new List<Person>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person();

            if (Name_txb.Text.Length < 3)
                throw new Exception("Name is too short!");

            if (Surname_txb.Text.Length < 3)
                throw new Exception("Surname is too short!");

            int age;
            if (int.TryParse(Age_txb.Text, out age) == false)
                throw new Exception("You need to enter a number!");

            if (Country_txb.Text.Length < 3)
                throw new Exception("Country is too short!");

            person.Name = Name_txb.Text;
            person.Surname = Surname_txb.Text;
            person.Age = int.Parse(Age_txb.Text);
            person.Country = Country_txb.Text;

            people.Add(person);
            People_lbx.Items.Add(person);
            UpdateTextBoxes();
        }

        private void Remove_btn_Click(object sender, RoutedEventArgs e)
        {
            int index = People_lbx.SelectedIndex;

            if (index >= 0)
            {
                People_lbx.Items.RemoveAt(index);
                people.RemoveAt(index);
                UpdateTextBoxes();
            }
        }

        private void Clear_btn_Click(object sender, RoutedEventArgs e)
        {
            People_lbx.SelectedIndex = -1;
            UpdateTextBoxes();
        }

        private void UpdateTextBoxes()
        {
            Name_txb.Text = "";
            Surname_txb.Text = "";
            Age_txb.Text = "";
            Country_txb.Text = "";
        }
    }
}
