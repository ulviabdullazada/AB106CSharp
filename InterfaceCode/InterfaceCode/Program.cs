using InterfaceCode.Models;

namespace InterfaceCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("SaBir.", "Guliyev");
            Student student2 = new Student("SaBir.", "Guliyev");

            Console.WriteLine($"Name:{student.Name} Email:{student.CodeMail}");
            Console.WriteLine($"Name:{student2.Name} Email:{student2.CodeMail}");
        }
    }
}
