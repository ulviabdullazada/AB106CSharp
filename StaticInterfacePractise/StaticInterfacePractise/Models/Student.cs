using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticInterfacePractise.Models
{
    internal class Student:Person
    {
        public string UniversityName { get; set; }
        public Student(string name, string surname):base(name,surname)
        {
            
        }
    }
}
