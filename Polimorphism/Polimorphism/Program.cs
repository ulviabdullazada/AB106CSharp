using Polimorphism.Interfaces;
using Polimorphism.Models;

namespace Polimorphism
{
    class Program
    {
        static void Main()
        {
            //Shark akula = new Shark("Akula");
            //Eagle qartal = new Eagle("Shahin");
            //Cat mestan = new("Şahin");
            //Animal[] animals = { akula, qartal, mestan, new Chicken("asd") };
            //Animal a = new Shark("Akula");
            //a.Eat();
            //foreach (var animal in animals)
            //{
            //    animal.Eat();
            //}
            ISwim dog = new Dog("Toplan");
            ISwim fish = new Shark("Akula");
            ISwim[] swimmers = new ISwim[] { fish, dog };
            foreach (var swimmer in swimmers)
            {
                swimmer.Swim();
            }
            IDivide c = new Calculate();
            Console.WriteLine(c.Divide(1, 5));
        }
    }
}
