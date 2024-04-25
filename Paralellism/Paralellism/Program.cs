using System.Diagnostics;

namespace Paralellism;
class Program
{
    static int Num;
    static object Ali = new object();
    static void Main(string[] args)
    {
        #region Concurrency
        //Loop2();
        //Loop1();
        //Thread t1 = new Thread(Loop2);
        //Thread t2 = new Thread(Loop1);
        //t1.Start();
        //Console.WriteLine("Salam");
        //t2.Start();
        //t1.Join();
        #endregion
        #region Paralellism
        //Parallel.Invoke(Loop1);
        //Console.WriteLine("Salam");
        #endregion
        #region Race condition
        //Thread shahin = new Thread(Increase);
        //Thread rauf = new Thread(Decrease);
        //rauf.Start();
        //shahin.Start();
        //rauf.Join();
        //shahin.Join();
        //Console.WriteLine(Num);
        #endregion
        #region Task
        //SeherYemeyi();
        SeherYemeyiAsync().Wait();
        #endregion
    }
    static async Task SeherYemeyiAsync()
    {
        Stopwatch sw = Stopwatch.StartNew();
        await Task.WhenAll(BoilSausageAsync(), PrepareTeaAsync(), SufreHazirlaAsync());
        //await BoilSausageAsync();
        //await PrepareTeaAsync();
        //await SufreHazirlaAsync();
        Console.WriteLine(sw.ElapsedMilliseconds);
    }
    static async Task BoilSausageAsync()
    {
        await Task.Delay(5000);
        Console.WriteLine("Sausage Boiled");
    }
    static async Task PrepareTeaAsync()
    {
        Console.WriteLine("Caydani doldurduq");
        await Task.Delay(3000);
        Console.WriteLine("Su qaynadi, cay demlendi");
        Console.WriteLine("Cay hazirdi");
    }
    static async Task SufreHazirlaAsync()
    {
        await Task.Delay(1500);
        Console.WriteLine("Sufre hazirdir");
    }





    static void SeherYemeyi()
    {
        Stopwatch sw = Stopwatch.StartNew();
        PrepareTea();
        BoilSausage();
        SufreHazirla();
        Console.WriteLine(sw.ElapsedMilliseconds);
    }
    static void BoilSausage()
    {
        Thread.Sleep(5000);
        Console.WriteLine("Sausage Boiled");
    }
    static void PrepareTea()
    {
        Console.WriteLine("Caydani doldurduq");
        Thread.Sleep(3000);
        Console.WriteLine("Su qaynadi, cay demlendi");
        Console.WriteLine("Cay hazirdi");
    }
    static void SufreHazirla()
    {
        Thread.Sleep(1500);
        Console.WriteLine("Sufre hazirdir");
    }

    //Shahin
    static void Increase()
    {
        for (int i = 0; i < 10000000; i++)
        {
            //Thread safe
            lock (Ali)
                Num++;
        }
    }
    //Rauf
    static void Decrease()
    {
        for (int i = 0; i < 10000000; i++)
        {
            //lock (Ali)
                Num--;
        }
    }
    static void Loop1()
    {
        for (int i = 0; i < 500; i++) 
        {
            Console.WriteLine(i);
        }
    }
    static void Loop2()
    {
        for (int i = -500; i < 0; i++)
        {
            Console.WriteLine(i);
        }
    }
}
