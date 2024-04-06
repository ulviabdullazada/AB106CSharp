using AbstractSolution.Models;

namespace AbstractSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.FactoryName= "Mercedes";
            car.Model = "e110";
            car.Color = "Black";

            Bicycle bicycle = new Bicycle();
            bicycle.FactoryName = "Forward";
            bicycle.Model = "Desna";
            bicycle.Color= "red";

            Vehicle[] vehicles = {car,bicycle};

            foreach (Vehicle nazrin in vehicles) 
            {
                Console.WriteLine(nazrin);
            }



        }
    }
}
