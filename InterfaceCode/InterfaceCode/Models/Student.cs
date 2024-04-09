using InterfaceCode.Exceptions;
using InterfaceCode.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCode.Models
{
    internal class Student:ICodeAcademy
    {
        static int Count = 0;
        private string _name;
        public int Id { get; set; }
        public string Name { get { return _name; } 
            set 
            { 
                if (value.Length>2 && value.Length<20)
                {
                    _name = value;
                }
                else
                {
                    throw new WrongInputException($"{value} is incorrect");
                };
            }
        }
        public string Surname { get; set; }
        public string CodeMail { get ; set; }

        public Student(string name,string surname) 
        {
            Id = ++Count;
            Name = name;
            Surname = surname;
            GenerateMail();
        }

        public void GenerateMail()
        {
           CodeMail= String.Concat(Name,'.',Surname,Id,"@code.edu.az").ToLower();
        }
    }
}
