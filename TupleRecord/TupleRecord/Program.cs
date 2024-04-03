using System;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace TupleRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Mutable, Immutable
            //mutable
            //immutable
            //int[] num = { 1, 2, 4, 5 };
            //foreach (int item in num)
            //{
            //    Console.WriteLine(item);
            //}
            //num[0] = 10;
            //foreach (int item in num)
            //{
            //    Console.WriteLine(item);
            //}
            //string text = "salam";
            //text = "S" + text.Substring(1);

            ////text[0] = 'S';
            //foreach (char letter in text)
            //{
            //    Console.WriteLine(letter);
            //}
            //int[] nums1 = new int[]{ 1, 2, 3, 4, 5 };
            //int[] nums2 = new int[]{ 1, 2, 3, 4, 5 };
            //StudentClass s1 = new StudentClass { Name = "Orxan", Surname = "Qurbanli" };
            //StudentClass s2 = new StudentClass { Name = "Orxan", Surname = "Qurbanli" };
            //s1.Surname = "jksdfkjsdhf";
            //string a = "s";
            //string b = "a";
            //a += "a";
            //b += "l";
            //a += "a";
            //a += "m";
            ////a = "S" + a.Substring(1);
            //Console.WriteLine(a + b);
            //StudentClass s1 = new StudentClass { Name = "Orxan", Surname = "Qurbanli" };
            //s1.Name = "sjkadfjksdfh";
            #endregion

            #region Record
            //StudentRecord std1 = new StudentRecord()
            //{
            //    Name = "Rauf",
            //    Surname = "Dostuyev",
            //    Age = 20,
            //    Group = "AB101",
            //    Uni = "AzTU"
            //};
            //StudentRecord std2 = std1 with { Name = "Nazrin", Surname = "Aliyeva" };
            //Console.WriteLine(std1);
            //Console.WriteLine(std2);
            //StudentRecord std2 = new StudentRecord("A", "B");
            //Console.WriteLine(Object.ReferenceEquals(std1, std2));
            //Console.WriteLine(std1 == std2);
            #endregion

            (int Num, string Text) result = A();
            //(string, int, string) record = ("John", 35, "Python Developer");
            Console.WriteLine(result.Num);

        }
        static (int, string) A()
        {
            return (1, "akjhkjashd");
        }
    }
    record StudentRecord(string Name = "XXX", string Surname = "YYY", int Age = 0, string Group = "", string Uni = "");


    class StudentClass
    {
        public string Name { get; init; }
        public string Surname { get; init; } = "XXX";
    }
}
