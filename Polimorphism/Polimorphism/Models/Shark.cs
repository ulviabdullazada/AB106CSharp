namespace Polimorphism.Models
{
    class Shark : Fish
    {
        public Shark(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Shark ate little fishes");
        }

        public void Sniff()
        {
            Console.WriteLine("Shark sniffed");
        }
    }
}
