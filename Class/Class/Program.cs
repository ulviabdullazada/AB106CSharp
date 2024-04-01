using Class.Models;
using System.ComponentModel.Design;

namespace Class
{
    class Program
    {
        static void Main()
        {
            //Student ibram = new Student 
            //{
            //    Name = "Ibrahim",
            //    Surname = "Xushmandi",
            //    Age = 20,
            //    GroupName = "AB106"
            //}; //object
            ////Student ibram = new();
            //Student garib = new Student();
            //garib.Name = "Garib";
            //garib.Surname = "Garibzade";
            //garib.Age = 20;
            //Student fuad = new Student();
            //fuad.Name = "Fuad";
            //fuad.Surname = "Mammadov";
            //fuad.Age = 19;
            //garib.IsActive = false;
            //Student[] students = { fuad, garib, ibram };
            //foreach (Student std in students)
            //{
            //    if (!std.IsActive) continue;
            //    std.PrintInfo();
            //}
            //garib.PrintInfo();
            //ibram.PrintInfo();
            //fuad.PrintInfo();
            //Student ibram = new Student("Ibrahim", "Xushmandi", 20);
            //Student fuad = new Student("Fuad", "Mammadov",20);
            //Student garib = new Student("Garib", "Garibzade",20);
            //Student nezrin = new("Nazrin","Aliyeva", 20);
            //var shahin = new Student("Shahin", "Alizade", 7);
            //Student nurlan = new("Nurlan");
            //Student[] stds = {ibram, fuad, garib, nezrin, shahin};
            //Developer dev = new Developer
            //{
            //    Name = "Anar",
            //    Surname = "Gasimzada",
            //    Age = 19,
            //    Languages = new string[] {"C#"}
            //};
            //foreach (var std in stds)
            //{
            //    std.PrintInfo();
            //}
            //Console.WriteLine(dev.Name);
            //Person azar = new Person { Name = "Azar", Surname = "Osmanli" };
            //Student fuad = new Student("Fuad", "Mammadov", 20);
            //Employee anar = new Employee { Name = "Anar", Surname = "Amanli", Age = 19 };
            //Developer rauf = new Developer { Name = "Rauf", Surname = "Dostuyev", Age = 21, Languages = new string[0] };
            Developer dev = new Developer();
            Person p = new Person("Samir", "Kerimov");
            Employee emp = new Employee("Ali", "Shukurov");
            Console.WriteLine(emp.Name);
            //azar.Print();
            //fuad.Print();
            //anar.Print();
            //rauf.Print();
        }
    }
}
