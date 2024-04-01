namespace Class.Models
{
    class Employee : Person //Inheritance
    {
        public byte Age;
        public Employee(string name,string surname) : base(name, surname)
        {
        }
        public Employee(string name, string surname, byte age) : this(name, surname)
        {
            Age = age;
        }
        public Employee(byte age)
        {
            Age = age;
        }
        public void Print()
        {
            Console.WriteLine($"{Name} {Surname} {Age}");
        }
    }
}
