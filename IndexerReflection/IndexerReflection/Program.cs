using System.Reflection;

namespace IndexerReflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test test = new Test();
            //test[0] = 11;
            //test[1] = 111;
            //test[2] = 110;
            //test[3] = 101;
            //test[11] = 101;
            //for (int i = 0; i < test.Length; i++) 
            //{
            //    Console.WriteLine(test[i]);
            //}
            //Mapper
            Test t = new Test();
            foreach (var item in typeof(Test).GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance))
            {
                Console.WriteLine(item.Name);
            }
        }
    }
    class Test
    {
        private int[] Arr { get; }
        private int A { get; set; } = 5;
        //public int Length => Arr.Length;
        //public int this[int i]
        //{
        //    get
        //    {
        //        return Arr[i];
        //    }
        //    set
        //    {
        //        if (value < 0)
        //            throw new ArgumentException("Dəyər 0-dan kiçik ola bilməz"); 
        //        if (i >= Arr.Length)
        //            throw new IndexOutOfRangeException();
        //        Arr[i] = value;
        //    }
        //}
        //public string this[string i]
        //{
        //    get
        //    {
        //        return "Salam";
        //    }
        //    set
        //    {

        //    }
        //}
        public Test()
        {
            //Arr = new int[10];
        }
    }
}
