using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerPractise.Models
{
    internal class Group
    {
        public Student[] _students=new Student[0];

        public Student this[string index]
        {
            get
            {
               foreach (Student student in _students) 
                { 
                    if (student.FinCode == index.ToUpper())
                    {
                        return student;
                    }
                
                }
                return null;

            }
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length-1]= student;
        }
    }
}
