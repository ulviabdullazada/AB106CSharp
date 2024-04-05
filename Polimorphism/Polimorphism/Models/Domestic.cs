namespace Polimorphism.Models
{
    abstract class Domestic : Animal
    {
        public Domestic(string name) : base(name)
        {
        }

        public void Pet()
        {
            Console.WriteLine("Being pet");
        }
    }
}
