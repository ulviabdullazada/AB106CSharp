using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasePractise.Models
{
    internal class Product
    {
        public string Name;
        public int Stock;
        public decimal Price;
        public Product(string name,int stock,decimal price)
        {
            Name = name;
            Stock = stock;
            Price = price;
        }
    }
}
