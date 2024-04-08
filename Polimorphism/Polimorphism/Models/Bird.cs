namespace Polimorphism.Models
{
    abstract class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Bird ate wheat");
        }
        //public abstract void Fly();
        public virtual void Fly()
        {
            Console.WriteLine("Bird flied");
        }
    }
}
