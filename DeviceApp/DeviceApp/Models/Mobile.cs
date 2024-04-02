using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceApp.Models
{
    internal class Mobile:Device
    {
        public string[] SimCards;
        public Mobile(double weigth, double width, double height,int simCount=1) :base(weigth,width,height) 
        {
            if(!(simCount>=1 && simCount <= 2))
            {
                simCount = 2;
            }
            SimCards = new string[simCount];
           

        }
        public void RemoveNumber(int i)
        {
            if(i<SimCards.Length)
            {
                SimCards[i] = null;
            }
            else
            {
                Console.WriteLine("Bele bir slot movcut deyil");
            }
        }
        public void AddNumber()
        {
            for (int i = 0; i < SimCards.Length; i++)
            {
                if (SimCards[i] == null)
                {
                    Console.WriteLine($"Zehmet {i + 1}-ci slota nomerin yerleshdirin:");
                    SimCards[i] = Console.ReadLine();
                    Console.WriteLine($"SimCard {i + 1} ugurla yerleshdirildi");
                    Console.Clear();

                    Console.WriteLine("Bashqa nomre elave etmek isteyirsiniz mi?\n(y,n)");
                    if (Console.ReadLine() == "y")
                    {
                        AddNumber();
                    }

                    return;

                }
            }
            Console.WriteLine("Nomre yerleri doludur");
        }

        public void GetNumbers()
        {
            foreach (var card in SimCards)
            {
                if (card == null)
                {
                    Console.WriteLine("Slot boshdur");
                    continue;
                }
                Console.WriteLine(card);
            }
        }
        //public void AddNumber()
        //{
        //    Number:

        //    for (int i = 0; i < SimCards.Length; i++)
        //    {
        //        if (SimCards[i] == null) 
        //        {
        //            Console.WriteLine($"Zehmet {i+1}-ci slota nomerin yerleshdirin:");
        //            SimCards[i]= Console.ReadLine();
        //            Console.WriteLine($"SimCard {i + 1} ugurla yerleshdirildi");
        //            Console.Clear();
                   
        //            Console.WriteLine("Bashqa nomre elave etmek isteyirsiniz mi?\n(y,n)");
        //            if (Console.ReadLine() == "y")
        //            {
        //                goto Number;
        //            }
                    
        //            return;

        //        }
        //    }
        //    Console.WriteLine("Nomre yerleri doludur");
        //}

    }
}
