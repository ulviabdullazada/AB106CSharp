using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractSolution.Models
{
    internal abstract class Vehicle
    {
        public string FactoryName { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double DriveTime { get; set; }
        public double DrivePath { get; set; }
        public void AverageSpeed()
        {
            Console.WriteLine(DrivePath/DriveTime);
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"{Color} {Model} ");
        }
        public override string ToString()
        {
            return $"{Model} {FactoryName}";
        }
        public abstract void DefineHarmness();
        

    }
}
