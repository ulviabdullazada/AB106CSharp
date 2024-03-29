using BasePractise.Models;
using System.Xml.Linq;

namespace BasePractise
{

    internal class Program
    {
        static void Main(string[] args)
        {
           

            Employee employee = new Employee("Orxan", "Qurbanli", 24,5);
            Employee employee2 = new Employee("Ali", "Churchill", 79,5);

            Business business = new Business("Code MMC");

            business.Hire(employee);
            business.Hire(employee2);

            foreach (var item in business.Employees)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine( "Ishden cixartdiqdan sonra:\n");
            business.Fire("Ali");

            foreach (var item in business.Employees)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}

//Person class:
//Name
//Surname
//Age
//---------------------
//Employee class: Person
//Salary=350
//Experience


//--------------------
//Business:
//Name
//Employee[] Employees=new Employee[0]
//Hire(Employee)
//Fire(name)
//-------------------------------- -
//Product classi:

//Name
//Price
//Stock
//----------------------
//Factory: Business
//ProductName
//Product Produce()  new Product(ProductName, 20,)

//---------------------- -
//Market:Business

//Product[] Products
//Sell(string name)
//Order()