using StaticInterfacePractise.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticInterfacePractise.Models
{
    internal abstract class Person
    {
        static int Count = 0;

        public int Id { get; set; } = 1;
        public string Name { get; set; }
        public string Surname { get; set; }
        public Person(string name, string surname)
        {
            //Name = Helper.Capitalize(name);
            Name = name.Capitalize();
            Surname = surname.Capitalize();
            Count++;
            Id = Count;

        }
    }
}
