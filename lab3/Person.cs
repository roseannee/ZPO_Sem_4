namespace lab3
{
    public class Person
    {
        public Person(string name, string surname, string birthdate, string residence)
        {
            Name = name;
            Surname = surname;
            Birthdate = birthdate;
            Residence = residence;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Birthdate { get; set; }
        public string Residence { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Surname}, {Birthdate}, {Residence}";
        }
    }
}
