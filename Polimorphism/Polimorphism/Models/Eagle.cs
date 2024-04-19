namespace Polimorphism.Models
{
    internal sealed class Eagle : Bird
    {
        public Eagle()
        {
            
        }
        public Eagle(string name) : base(name)
        {
        }

        public void Hunt()
        {
            Console.WriteLine("Eagle hunting...");
        }
        public override void Eat()
        {
            Console.WriteLine("Eagle ate what it hunted");
        }
    }
}
