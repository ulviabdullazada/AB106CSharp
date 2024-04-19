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
            //for (int i = 0; i < test.Length; i++)
            //{
            //    Console.WriteLine(test[i]);
            //}
            //Mapper
            //Test t = new Test();
            //foreach (var item in typeof(Test).GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance))
            //{
            //    Console.WriteLine(item.Name);
            //}
            IntArray arr = new IntArray();
            arr.Add(1);
            arr.Add(1);
            arr.Add(1);
            arr.Add(1);
            arr.Add(1);
            for (int i = 0; i < 20; i++) 
            { 
                Console.WriteLine(arr[i]);
            }
        }
    }
    class IntArray
    {
        int[] _arr;
        public int Length => _arr.Length;
        public IntArray()
        {
            _arr = new int[0];
        }
        public IntArray(params int[] nums)
        {
            _arr = nums;
        }
        public void Add(int val)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = val;
        }
        //public int this[int index]
        //{
        //    get
        //    {
        //        return _arr[index];
        //    }
        //}
        public int this[int index]
        {
            get
            {
                return index * 10;
            }
        }
    }
    //class Test
    //{
    //    private int[] Arr { get; }
    //    private int A { get; set; } = 5;
    //    public int Length => Arr.Length;
    //    public int this[int i]
    //    {
    //        get
    //        {
    //            return Arr[i];
    //        }
    //        set
    //        {
    //            if (value < 0)
    //                throw new ArgumentException("Dəyər 0-dan kiçik ola bilməz");
    //            if (i >= Arr.Length)
    //                throw new IndexOutOfRangeException();
    //            Arr[i] = value;
    //        }
    //    }
    //    //public string this[string i]
    //    //{
    //    //    get
    //    //    {
    //    //        return "Salam";
    //    //    }
    //    //    set
    //    //    {

    //    //    }
    //    //}
    //    public Test()
    //    {
    //        //Arr = new int[10];
    //    }
    //}
}
