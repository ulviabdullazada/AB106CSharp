namespace Methods
{
    internal class Program
    {
        //static void IntroMenu()
        //{
        //    Console.WriteLine("Meynunu gormek ucun Y-a toxunun");
        //    string input = Console.ReadLine();
        //    if (input == "y")
        //    {
        //        Console.WriteLine("Menyu...");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Sagol");
        //    }
        //}
        //static void SayHi(string ad)
        //{
        //    Console.WriteLine("Salam "+ ad);
        //}
        //static int Calc(int num, int perc)
        //{
        //    return num * perc / 100;
        //}
        //static int Calc(int num, int perc)
        //{
        //    return num * perc / 100;
        //}
        //static double Calc(float num, float perc)
        //{
        //    return Math.Round(num * perc / 100);
        //}
        //static bool IsEven(int num)
        //{
        //    return num % 2 == 0;
        //    //if (num % 2 == 0)
        //    //{
        //    //    return true;
        //    //}
        //    //else
        //    //{
        //    //    return false;
        //    //}
        //}
        //"Salam" => a
        //static bool HasLetter(string word, char letter)
        //{
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (letter == word[i])
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        static void Main()
        {
            //IntroMenu();
            //IntroMenu();
            //IntroMenu();
            //string name = "Ali";
            //SayHi(name);
            //SayHi("Emil");
            //SayHi("Rauf");
            //SayHi(22);
            //float salary = Convert.ToSingle(Console.ReadLine());
            //double result = Calc(salary, 25);
            //Console.WriteLine(salary + result);
            //IsEven(26);
            //Console.WriteLine();
            //Console.WriteLine(HasLetter("Salam",'z'));
            //Test(15, "Salam");
            //Test("Salam123", 15);
            //Test("asd",11);
            //Print();
            //Print("Ibrahim sus");
            //Print();
            PrintArr(2,2,3,4,5,6,7,8,9,10);
        }

        static void PrintArr(int num, params int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }


        //static void Print(int a = 0, string word = "Salam")
        //{
        //    Console.WriteLine(a + " " + word);
        //}

        //method signature
        //methhod name, parameters count, parameters type
        //static void Test(string str, int num1)
        //{
        //    Console.WriteLine(str);
        //}
        //static void Test(string str, int num)
        //{
        //    Console.WriteLine(num);
        //}
        //static void Test()
        //{
        //    Console.WriteLine("Salam");
        //}
    }
}
