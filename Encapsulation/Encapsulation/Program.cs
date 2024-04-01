using Encapsulation.Models;

namespace Encapsulation;
internal class Program
{
    static void Main(string[] args)
    {
        #region Properties
        //Person p1 = new Person(10)
        //{
        //    Age = -1
        //};
        //Console.WriteLine(p1.Age);
        //p1.Age = -2;
        //Console.WriteLine(p1.GetAge());
        //Console.WriteLine(p1.GetAge());
        //Person p2 = new Person(10);
        //Console.WriteLine(p1.Age);
        //Console.WriteLine(p2.Age);
        //p1.Age = 2;
        //Console.WriteLine(p1.Age);
        #endregion
        bool isContinue = true;
        Tesla s = new Tesla("Z");
        do
        {
            Console.Clear();
            Console.WriteLine(@"1. Drive
2. MaxSpeed
3. Exit");
            int input = Convert.ToInt32(Console.ReadLine());
            switch(input)
            {
                case 1:
                    s.Drive();
                    break;
                case 2:
                    s.MaxSpeed();
                    break;
                case 3:
                    isContinue = false;
                    break;
            }
        } while (isContinue);
        Console.WriteLine(s.Battery);
    }
}
