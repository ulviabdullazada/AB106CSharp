namespace Class.Models
{
    class Employee : Person //Inheritance
    {
        public byte Age;
        public void Print()
        {
            Console.WriteLine($"{Name} {Surname} {Age}");
        }
    }
}
