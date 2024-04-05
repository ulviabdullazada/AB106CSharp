using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSolution.Models
{
    internal class Manager
    {
        protected void GetPromotion(Employee employee)
        {
            employee.Salary += 100;
        }
    }
}
