using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionEnumIndexer.Extensions
{
    static class StringExtension
    {
        public static string ToCaptalize(this string txt)
        {
            return Char.ToUpper(txt[0]) + txt.Substring(1).ToLower();
        }
    }
}
