namespace Polimorphism.Models
{
    class Cat : Domestic
    {
        public Cat(string name) : base(name)
        {
        }

        public void Risofkalanmaq()
        {
            Console.WriteLine("Meow");
        }
        public override void Eat()
        {
            Console.WriteLine("Cat ate lausania");
        }
    }
}
