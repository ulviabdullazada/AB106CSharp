using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasePractise.Models
{
    internal class Business
    {
        public string Name;
        public Employee[] Employees=new Employee[0];  
        public Business(string name)
        {
                Name = name;
        }

        public void Hire(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length-1] = employee;
        }
        public void Fire(string name)
        {
            Employee[] newArr = new Employee[Employees.Length - 1];
            int j = 0;
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].Name != name)
                {
                    newArr[j]= Employees[i];
                    j++;
                }
            }
            Employees=newArr;
        }
        
    }
}
