using StaticInterfacePractise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticInterfacePractise.Models
{
    internal class CodeStudent:Student,ICodeAcademy
    {
        public string CodeMail { get; set; }
        public CodeStudent(string name, string surname):base(name,surname)
        {
            
        }

       
    }
}
