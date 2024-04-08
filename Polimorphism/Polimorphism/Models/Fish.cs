using Polimorphism.Interfaces;

namespace Polimorphism.Models
{
    abstract class Fish : Animal, ISwim
    {
        public Fish(string name) : base(name)
        {
        }

        public int MaxSwimTime { get; set; } = -1;

        public virtual void Swim()
        {
            Console.WriteLine("Fish swimming");
        }
    }
}
