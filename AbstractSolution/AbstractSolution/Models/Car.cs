using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSolution.Models
{
    internal class Car : Vehicle
    {
        public int DoorCount { get; set; } = 4;
        public bool IsElectric { get; set; }

        public override void DefineHarmness()
        {
           if (IsElectric)
            {
                Console.WriteLine("Low");
            }
           else
            {
                Console.WriteLine("High");
            }
        }
    }
}
