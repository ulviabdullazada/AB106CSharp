using System.Threading.Channels;

namespace Delegate
{
    //delegate bool NumberDel<T>(T number);
    //delegate bool StringDel(string str);
    //delegate void Action(string s1, string s2);
    delegate void CustomAction<T>(T t1);
    delegate void CustomAction<T1, T2>(T1 t1, T2 t2);
    delegate TReturn CustomFunc<out TReturn>();
    delegate TReturn CustomFunc<in T1, out TReturn>(T1 t1);
    class Program
    {
        static void Main(string[] args)
        {
            //NumberDel funcs = IsPrime;
            //Console.WriteLine(funcs);
            //Find("salam", delegate (string str)
            //{
            //    return str.Length > 5;
            //});
            //Find("salam", str => str.Length > 5);
            //Predicate
            Action<string, string> actions;
            Func<bool, string> func;
            //Find("salam", HasUpper);
            List<string> strings = new List<string>();
            strings.Add("Ibram");
            strings.Add("Samir");
            strings.Add("Ali");
            strings.Add("Emil");
            strings.Add("Zaycik");
            //strings.ForEach(s => Console.WriteLine(s));
            //Console.WriteLine(strings.Any(a => a.Length < 4));
            var newList = strings.FindAll(x => x.ToLower().Contains("i"));
            newList.ForEach(x => Console.WriteLine(x));

        }
        //static void Find(string str, Func<string, bool> func)
        //{
        //    if (func(str))
        //    {
        //        Console.WriteLine("Shert odenilir");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Shert odenilmir");
        //    }
        //}
        //static bool HasUpper(string str)
        //{
        //    foreach (var item in str)
        //    {
        //        if (Char.IsUpper(item))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //static bool HasLower(string str)
        //{
        //    foreach (var item in str)
        //    {
        //        if (Char.IsLower(item))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //static bool IsEven(int num)
        //{
        //    return num % 2 == 0;
        //}
        //static bool IsPrime(int num23)
        //{
        //    if (IsEven(num23) && num23 < 3) return false;
        //    for (int i = 3; i <= num23 * num23; i+=2)
        //    {
        //        if (num23 % i == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        //static bool IsDivided3(int num4)
        //{
        //    return num4 % 3 == 0;
        //}
    }
}
