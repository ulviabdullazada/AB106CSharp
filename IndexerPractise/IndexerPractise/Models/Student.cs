using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerPractise.Models
{
    internal class Student
    {
		private string _finCode;

        public string Name { get; set; }
        public string Surname { get; set; }

        public string FinCode
		{
			get { return _finCode; }
			private set 
			{
				if (value.Length==7)
				{
                    _finCode = value.ToUpper();
                }
				
			}
		}
        public Student(string name, string surname,string fin)
        {
            FinCode = fin;
            Name = name;
            Surname = surname;
        }

    }
}
