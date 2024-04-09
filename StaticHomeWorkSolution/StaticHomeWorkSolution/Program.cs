
using StaticHomeWorkSolution.Models;

namespace StaticHomeWorkSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student shahin=new Student("Shahin","Alizada");
            Student ali=new Student("Ali","Shukurov");
            Student nazrin=new Student("Nazrin","Eliyeva");
            Student ibra=new Student("Ibrahim","Garibzada");

            Group group = new Group("AB106");
            Group test = new Group("AF103");
            Group sisadminler = new Group("AS200");

            group.AddStudent(shahin);
            group.AddStudent(ali);

            test.AddStudent(nazrin);

            sisadminler.AddStudent(ibra);

            group.GetGroupInfo();
            Console.WriteLine("--------------------------------");
            test.GetGroupInfo();

            Group.AddGroup(group);
            Group.AddGroup(sisadminler);
            Group.AddGroup(test);

            //for (int i = 0; i < Group._groups.Length; i++)
            //{

            //    Console.WriteLine(Group._groups[i]);
            //}


            //Group.RemoveGroup(2);
            //Group.RemoveGroup(3);

            //Console.WriteLine("Silindikden sonra");

            //for (int i = 0; i < Group._groups.Length; i++)
            //{

            //    Console.WriteLine(Group._groups[i]);
            //}


        }
    }
}
