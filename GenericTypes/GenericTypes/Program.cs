using System.Collections.Generic;

namespace GenericTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IntArrayList list = new IntArrayList();
            //list.Add(1);
            //list.Add(12);
            //list.Add(21);
            //list.Add(30);
            //list.Add(32);
            //list.Add(10);
            //list.Add(12);
            ////list.GetElements();
            //Console.WriteLine(list); //{1,12,21,30,32,10,12}
            //StringArrayList strs = new StringArrayList();
            //strs.Add("Salam");
            //strs.Add("Aleykum");
            //strs.GetElements();
            //ObjectArrayList objs = new ObjectArrayList(typeof(String));
            //objs.Add("12");
            //objs.Add("13");
            //objs.Add("14");
            //objs.Add("15");
            ////objs.Add(true);
            ////objs.Add("Salam");
            //objs.GetElements();
            //GenericList<int> nums = new GenericList<int>();
            //nums.Add(1);
            //nums.Add(2);
            //nums.Add(3);
            //var students = new Student[] {
            //    new Student
            //    {
            //        Name = "Nurlan",
            //        Surname = "Abbasov"
            //    },
            //    new Student
            //    {
            //        Name = "Ali",
            //        Surname = "Shukurov"
            //    }
            //};
            //GenericList<Student> stdArr = new GenericList<Student>(students);
            //stdArr.GetElements();
            HashSet<int> nums = new HashSet<int>();
            LinkedList<int> list = new LinkedList<int>();
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Rauf", "Salam");

            Console.WriteLine(dictionary["Rauf"]);
        }
    }
    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
    class GenericList<T>
    {
        T[] _arr;
        public int Capacity { get; set; } = 5;
        public int Count { get; private set; } = 0;
        public GenericList()
        {
            _arr = new T[Capacity];
        }
        public GenericList(int capacity)
        {
            Capacity = capacity;
            _arr = new T[Capacity];
        }
        public GenericList(T[] arr, int capacity = 5)
        {
            Capacity = capacity;
            _arr = arr;
            Count = arr.Length;
        }
        public void Add(T value)
        {
            if (_arr.Length == Count)
            {
                Array.Resize(ref _arr, Count + Capacity);
            }
            _arr[Count] = value;
            Count++;
        }
        public void GetElements()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
    }
    class IntArrayList{
        int[] _arr;
        public int Capacity { get; set; } = 5;
        public int Count { get; private set; } = 0;
        public IntArrayList()
        {
            _arr = new int[Capacity];
        }
        public IntArrayList(int capacity)
        {
            Capacity = capacity;
            _arr = new int[Capacity];
        }
        public void Add(int value)
        {
            if (_arr.Length == Count)
            {
                Array.Resize(ref _arr, Count + Capacity);
            }
            _arr[Count] = value;
            Count++;
        }
        public void GetElements()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
    }
    class ObjectArrayList
    {
        object[] _arr;
        public int Capacity { get; set; } = 5;
        public int Count { get; private set; } = 0;
        private Type _listType;
        public ObjectArrayList(Type listType)
        {
            _arr = new object[Capacity];
            _listType = listType;

        }
        public ObjectArrayList(int capacity, Type listType)
        {
            Capacity = capacity;
            _arr = new object[Capacity];
            _listType = listType;
        }
        public void Add(object value)
        {
            if (value.GetType().Name == _listType.Name)
            {
                if (_arr.Length == Count)
                {
                    Array.Resize(ref _arr, Count + Capacity);
                }
                _arr[Count] = value;
                Count++;
            }
            else
            {
                throw new ArrayTypeMismatchException();
            }
        }
        public void GetElements()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
    }
    class StringArrayList
    {
        string[] _arr;
        public int Capacity { get; set; } = 5;
        public int Count { get; private set; } = 0;
        public StringArrayList()
        {
            _arr = new string[Capacity];
        }
        public StringArrayList(int capacity)
        {
            Capacity = capacity;
            _arr = new string[Capacity];
        }
        public void Add(string value)
        {
            if (_arr.Length == Count)
            {
                Array.Resize(ref _arr, Count + Capacity);
            }
            _arr[Count] = value;
            Count++;
        }
        public void GetElements()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(_arr[i]);
            }
        }
    }
}
