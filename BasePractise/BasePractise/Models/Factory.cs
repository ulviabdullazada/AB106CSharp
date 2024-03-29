using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasePractise.Models
{
    internal class Factory:Business
    {
        public string ProductName;
        public Factory(string name,string prName):base(name)
        {
            ProductName = prName;
        }

        public Product Produce()
        {
            //Product product = new Product(ProductName, Employees.Length * 5, 20);
            //return product;

            return new Product(ProductName, Employees.Length * 5, 20);
        }
    }
}
