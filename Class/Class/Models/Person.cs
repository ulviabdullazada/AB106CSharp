namespace Class.Models
{
    class Person
    {
        public string Name;
        public string Surname;
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public Person()
        {
        }
        public void Print()
        {
            Console.WriteLine($"{Name} {Surname}");
        }
    }
}
