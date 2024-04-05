namespace Polimorphism.Models
{
    class Chicken : Bird
    {
        public Chicken(string name) : base(name)
        {
        }

        public override void Fly()
        {
            Console.WriteLine("Chicken cannot fly =(");
        }
    }
}
