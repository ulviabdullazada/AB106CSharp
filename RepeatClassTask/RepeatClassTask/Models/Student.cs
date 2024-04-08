using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatClassTask.Models
{
    internal class Student
    {
        static int Count = 1;
        public int Id;
        string _fullname;


        public string FullName
        {
            get { return _fullname; }
            set
            {
                if (IsTrue(value))
                {
                    _fullname = value;
                }
                else if (!IsTrue(value))
                {
                    Console.WriteLine("dogru formatta yazilmayib");
                }

            }
        }




        public Student(string fullname)
        {
            FullName = fullname;
            Id = Count;
            Count++;

        }


        static bool CheckFullname(string FullName)
        {
            int probel = 0;
            for (int i = 0; i < FullName.Length; i++)
            {
                if (FullName[i] == ' ')
                    probel++;

            }
            for (int j = 0; j < FullName.Length; j++)
            {
                if (FullName[j] == ' ' && char.IsUpper(FullName[0]) && char.IsUpper(FullName[j + 1])&& probel==1 )

                {
                    return true;
                }



            }

            return false;
        }

        static bool IsLetter(string FullName)
        {
            for (int i = 0; i < FullName.Length; i++)
            { 
                if (!char.IsLetter(FullName[i]) && FullName[i] !=' ')
                { return false; }
            }
            return true;

        }

        static bool NameCheck(string FullName)
        {
            string[] names = FullName.Split(' ');

            if (names[0].Length >= 3 && names[0].Length <= 10 && names[1].Length >= 3 && names[1].Length <= 10)
            {
                if (names[0].Substring(0, 1).ToUpper() + names[0].Substring(1).ToLower() == names[0] && names[1].Substring(0, 1).ToUpper() + names[1].Substring(1).ToLower() == names[1])
                { return true; }
            }

            return false;
        }

        private static bool IsTrue(string FullName)
        {
            if (CheckFullname(FullName) && IsLetter(FullName) && NameCheck(FullName))
            { return true; }
            return false;

        }

     



    }
}
