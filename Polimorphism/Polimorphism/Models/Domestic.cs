namespace Polimorphism.Models
{
    abstract class Domestic : Animal
    {
        protected Domestic()
        {
            
        }
        public Domestic(string name) : base(name)
        {
        }

        public void Pet()
        {
            Console.WriteLine("Being pet");
        }
    }
}
