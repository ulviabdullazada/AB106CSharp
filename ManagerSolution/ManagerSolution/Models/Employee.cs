using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSolution.Models
{
    internal class Employee
    {
        private string _name;
        decimal _salary;
        bool _isSuccessfull;


        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length >= 3 && value.Length <= 25)
                {
                    _name = value;
                }
            }
        }
        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value>=350) 
                { 
                    _salary = value;
                }
            }
        }
        public bool IsSuccessfull
        {
            get { return _isSuccessfull; }
            set { _isSuccessfull = value; }
        }

        public Employee(string name, decimal salary, bool success)
        {
            Name = name;
            Salary = salary;
            IsSuccessfull = success;
        }

    }
}
