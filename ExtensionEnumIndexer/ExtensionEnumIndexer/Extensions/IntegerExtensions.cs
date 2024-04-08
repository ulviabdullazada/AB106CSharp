using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionEnumIndexer.Extensions
{
    static class IntegerExtensions
    {
        public static int Add(this int num2, int num1, int num3 = 10)
        {
            return num1 + num2+num3;
        }
    }
}
