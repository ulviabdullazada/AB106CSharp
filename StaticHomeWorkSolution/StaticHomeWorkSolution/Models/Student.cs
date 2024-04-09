using StaticHomeWorkSolution.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticHomeWorkSolution.Models
{
    internal class Student
    {
        static int Count = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Student(string name,string surname)
        {
            
            Id = Count;
            Count++;
            Name = name.Capitalize();
            Surname = surname.Capitalize();
        }

        public void GetInfo()
        {
            Console.WriteLine($"{Id} {Name} {Surname}");
        }



    }
}
