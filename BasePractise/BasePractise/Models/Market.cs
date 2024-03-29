using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasePractise.Models
{
    internal class Market:Business
    {
        public Product[] Products=new Product[0];
        public Market(string name):base(name)
        {
                
        }
    }
}
