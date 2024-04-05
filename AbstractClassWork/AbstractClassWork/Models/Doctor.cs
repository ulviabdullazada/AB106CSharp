using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassWork.Models
{
    internal class Doctor:Employee
    {
        public Doctor(string name, string surname, int age) : base(name, surname, age)
        {
            
        }
        public void Heal(Person person)
        {
            Console.WriteLine("Healed");

        }
    }
}
