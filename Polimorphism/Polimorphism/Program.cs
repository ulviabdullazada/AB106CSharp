using Polimorphism.Models;

namespace Polimorphism
{
    class Program
    {
        static void Main()
        {
            Shark akula = new Shark("Akula");
            Eagle qartal = new Eagle("Shahin");
            Cat mestan = new("Şahin");
            Animal[] animals = { akula, qartal, mestan, new Chicken("asd") };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
