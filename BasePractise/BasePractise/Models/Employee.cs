﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasePractise.Models
{
    internal class Employee : Person 
    {



        public decimal Salary = 350;
        public int Experience;

        public Employee(string name, string surname, int age,int exp) : base(name, surname, age)
        {
            Experience = exp;
        }
    }
}
