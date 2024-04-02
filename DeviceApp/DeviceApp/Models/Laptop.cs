using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceApp.Models
{
    internal class Laptop:Device
    {
        public byte PortCount;
        public Laptop(double weigth, double width, double height):base(weigth, width, height) { }
        
    }
}
