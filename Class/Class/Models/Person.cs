namespace Class.Models
{
    class Person : Object
    {
        public string Name;
        public string Surname;
        public void Print()
        {
            Console.WriteLine($"{Name} {Surname}");
        }
    }
}
