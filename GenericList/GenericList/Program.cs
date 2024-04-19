using GenericList.Models;
using System;
using System.Reflection;

namespace GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] ss = {"asas","asdfsdf"};

                CustomList<int> list = new CustomList<int>();
            list.Add(3);
            list.Add(5);
            list.Add(1);
            list.Add(6);
            list.Add(5);

            //Console.WriteLine(list);

            //Console.WriteLine(list.LastIndexOf(5));


            CustomList<string> strList= new CustomList<string>();
            strList.Add("salam");
            strList.Add("asd");
            strList.Add("rgerg");
            strList.Add("jytj");
            strList.Add("salam");

            Console.WriteLine(strList.IndexOf("salam"));







        }
       
    }
}
