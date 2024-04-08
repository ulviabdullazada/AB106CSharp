using RepeatClassTask.Models;

namespace RepeatClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            { 
                string fullname =Console.ReadLine();
                Student student = new Student(fullname);

            } 
            while (true);
        }
    }
}
