using PropertyTask.Models;
using System.Text;

namespace PropertyTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Product pr = new Product();
            pr.Name = "Salam";
            pr.Price = 12f;
            Console.WriteLine(pr.Name);
        }
    }
}
