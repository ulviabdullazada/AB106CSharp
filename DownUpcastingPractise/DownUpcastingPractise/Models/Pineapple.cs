using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownUpcastingPractise.Models
{
    internal class Pineapple:Fruit
    {
        public int VitaminE;
        public int VitaminD;

        public Pineapple(decimal price, string sort, int vitE, int vitD) : base(price, sort)
        {
            VitaminE = vitE;
            VitaminD = vitD;

        }

        public override void Taste()
        {
            Console.WriteLine("Tastes like Pineapple");
        }
    }
}
