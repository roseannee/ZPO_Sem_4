namespace lab7
{
    internal class Person : ViewModel
    {
        public Person() { }

        private string _name;
        private string _surname;
        private int _age;
        private string _country;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                _surname = value;
                OnPropertyChanged();
            }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
    }
}
