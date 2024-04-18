using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownUpcastingPractise.Models
{
    internal class Orange:Fruit
    {
        public int VitaminC;

        public Orange(decimal price, string sort, int vitC) : base(price, sort)
        {
            VitaminC = vitC;
        }

        public override void Taste()
        {
            Console.WriteLine( "Tastes like orange");
        }
    }
}
