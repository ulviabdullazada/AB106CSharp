using IndexerException.Exceptions;
using System.Text;

namespace IndexerException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct, try catch
            //Student std = new Student(12, false);
            //Student std2 = std;
            //std2.a = 5;
            //Console.WriteLine(std.a);

            //ValueStudent valStd = new ValueStudent(12, false);
            //ValueStudent valStd2 = valStd;
            //valStd2.a = 5;
            //Console.WriteLine(valStd.a);
            //Console.OutputEncoding = Encoding.UTF8;
            //try
            //{
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    int num2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(num1 / num2);
            //    return;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Salam");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Daxil olunan dəyər uyğun deyil");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("0-a bölmək qadağandır");
            //}


            //int sum = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    sum+=i;
            //}
            //Console.WriteLine(sum);
            #endregion

            try 
            {
                string name = Console.ReadLine();
                if (!CheckCapitalize(name)) 
                {
                    throw new NameFormatException();
                }
            }
            catch (NameFormatException ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
        static bool CheckCapitalize(string txt)
        {
            if (!Char.IsUpper(txt[0]))
                return false;
            for (int i = 1; i < txt.Length; i++) 
            {
                if (!Char.IsLower(txt[i]))
                    return false;
            }
            return true;
        }
    }
    //struct ValueStudent
    //{
    //    public int a;
    //    public bool b;

    //    public ValueStudent(int A, bool B)
    //    {
    //        a = A;
    //        b = B;
    //    }
    //}
    //class Student:Person
    //{
    //    public int a;
    //    public bool b;
    //    public sealed override void Salam()
    //    {
    //        Console.WriteLine("Hello");
    //    }
    //}
    //class A : Student
    //{
    //    public override void Salam()
    //    {
    //    }
    //}
    abstract class Person
    {
        public string Name { get; set; }
        public virtual void Salam()
        {
            Console.WriteLine("Salam");
        }
    }
}
