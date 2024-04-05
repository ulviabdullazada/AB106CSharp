using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassWork.Models
{
    internal abstract class Person
    {
        string _name;
        string _surname;
        int _age;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public virtual int Age
        {
            get { return _age; }
            set 
            { 
                if (value > 0&&value<200)
                {
                    _age = value;
                }
            }
        }

        public Person(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Console.WriteLine("Person ctor ishe dushdu");
        }
        public abstract void GetInfo();
    }
}
