using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerException.Exceptions
{
    class NameFormatException : Exception
    {
        public NameFormatException() : base("Ad formatı yalnışdır.")
        {
        }

        public NameFormatException(string? message) : base(message)
        {
        }
    }
}
