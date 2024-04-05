using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerSolution.Models
{
    internal class Assistant:Manager
    {
        public void GetFeedback(Employee employee)
        {
            if (employee.IsSuccessfull) 
            {
                 GetPromotion(employee);
            }
        }
    }
}
