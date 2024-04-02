using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceApp.Models
{
    internal class Device
    {
        public double Weight;
        public double Width;
        public double Height;
        public bool Status=false;

        public Device(double weigth,double width,double height)
        {
            Weight = weigth;
            Width = width;
            Height = height;
        }
        public void OpenDevice()
        {
            if (!Status) {
                Status= true;
                Console.WriteLine("Device opening...");
            }else
            {
                Console.WriteLine( "Device already opened");
            }
        }
        public void CloseDevice()
        {
            if (Status)
            {
                Status= false;
                Console.WriteLine( "Device closing...");
            }else
            {
                Console.WriteLine("Device already closed");
            }
        }
    }
}
