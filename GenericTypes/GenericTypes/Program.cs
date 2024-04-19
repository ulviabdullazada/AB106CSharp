using GenericTypes.Models;

namespace GenericTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group ab106 = new("AB106");
            Group ab105 = new("AB105");

            List<Student> students = new();
            students.Add(new Student("Ibrahim", "Khushmandi",20,200, ab106 ));
            students.Add(new Student("Garib", "Garibzada",20,300, ab106 ));
            students.Add(new Student("Shahin", "Alizada", 20, 400, ab105));
            students.Add(new Student("Nurlan", "Abbasov",19,160, ab106 ));

            //students.FindAll(s => s.Group == ab106)
            //    .ForEach(s => Console.WriteLine(s.Id + " " + s.Name));

            //Burdan yuxarisi taska aiddi.


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
            //HashSet<int> nums = new HashSet<int>();
            //LinkedList<int> list = new LinkedList<int>();
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //Dictionary<string, string> dictionary = new Dictionary<string, string>();
            //dictionary.Add("Rauf", "Salam");

            //Console.WriteLine(dictionary["Rauf"]);
            //GenericList<int> list = new GenericList<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);
            //list.Add(6);
            ////Console.WriteLine(list.Any(x=>x%2 ==0));
            ////Console.WriteLine(list.All(x=>x%2 ==0));
            //foreach (var item in list.FindAll(x => x % 2 == 0))
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
    //class Student
    //{
    //    public string Name { get; set; }
    //    public string Surname { get; set; }
    //    public override string ToString()
    //    {
    //        return Name + " " + Surname;
    //    }
    //}
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
        public bool Any(Predicate<T> pred)
        {
            for (int i = 0; i < Count; i++)
            {
                if (pred(_arr[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public bool All(Predicate<T> pred)
        {
            for (int i = 0; i < Count; i++)
            {
                if (!pred(_arr[i])) return false;
            }
            return true;
        }
        public IEnumerable<T> FindAll(Predicate<T> pred)
        {
            for (int i = 0; i < Count; i++)
            {
                if (pred(_arr[i])) 
                    yield return _arr[i];
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
