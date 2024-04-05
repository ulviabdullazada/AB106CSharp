namespace Polimorphism.Models
{
    abstract class Fish : Animal
    {
        public Fish(string name) : base(name)
        {
        }

        public void Swim()
        {
            Console.WriteLine("Fish swam");
        }
    }
}
