using ManagerSolution.Models;

namespace ManagerSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Ali", 350m, false);

            Assistant assistant = new Assistant();

            assistant.GetFeedback(employee);

            Console.WriteLine(employee.Salary);
        }
    }
}
