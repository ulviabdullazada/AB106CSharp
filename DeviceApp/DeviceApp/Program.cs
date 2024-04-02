using DeviceApp.Models;

namespace DeviceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobile mobile = new Mobile(10, 15, 20, 2);
            
            mobile.AddNumber();


            mobile.GetNumbers();
            mobile.RemoveNumber(0);
            mobile.RemoveNumber(5);
            Console.WriteLine("\nsilindikden sonra\n");
            mobile.GetNumbers();





        }
    }
}
