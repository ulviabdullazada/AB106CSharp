using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownUpcastingPractise.Models
{
    internal abstract class Fruit
    {
        public decimal Price;
        public string Sort;

        protected Fruit(decimal price,string sort)
        {
            Sort = sort;
            Price = price;
        }

        public abstract void Taste();
    }
}
