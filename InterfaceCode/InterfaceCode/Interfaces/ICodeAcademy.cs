using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCode.Interfaces
{
    internal interface ICodeAcademy
    {
        public string CodeMail { get; set; }

         void GenerateMail();
    }
}
