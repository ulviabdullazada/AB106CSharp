using DownUpcastingPractise.Models;

namespace DownUpcastingPractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple(10m, "Qizilehmedi", 70, 45);
            Pineapple pineapple = new Pineapple(40m, "Afrika", 30, 90);
            Orange orange = new Orange(13m, "Lenkeran", 120);

            Fruit[] basket = {apple,pineapple,orange};

            foreach (Fruit fruit in basket)
            {
                Apple app = fruit as Apple;
                Pineapple pine = fruit as Pineapple;
                Orange org = fruit as Orange;

                if (app != null)
                {
                    Console.WriteLine(app.VitaminA);
                }
               if (pine != null)
                {
                    Console.WriteLine(pine.VitaminE);
                }
                if (org!=null)
                {
                    Console.WriteLine(org.VitaminC);
                }

                
                //if (fruit is Apple app)
                //{
                //    Console.WriteLine(app.Sort+app.VitaminA + " " + app.VitaminB);
                //}
                //else if(fruit is Pineapple pine)
                //{
                //    Console.WriteLine(pine.Sort+pine.VitaminE+" "+pine.VitaminD);
                //}
                //else if(fruit is Orange org)
                //{
                //    Console.WriteLine(org.Sort+" "+org.VitaminC);
                //}

            }


        }
    }
}
