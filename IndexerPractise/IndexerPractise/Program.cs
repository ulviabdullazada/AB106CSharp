using IndexerPractise.Models;

namespace IndexerPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student samuray = new Student("samuray","katanov","2dasfg6");
            Student  inara= new Student("inara","ahmadova","4restar");

            Group group =new Group();
            group.AddStudent(samuray);
            group.AddStudent(inara);


            Student student=group["2dasfg6234234"];


            Console.WriteLine(student);

            //if(student == null)
            //{
            //    //throw new Exception("Student was not found");
            //    Console.WriteLine("NotFound");
            //}
            //else 
            //{ 
            //    Console.WriteLine(student.Name + " " + student.Surname);
            //}




        }
    }
}
