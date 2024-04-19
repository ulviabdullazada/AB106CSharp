using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList.Models
{
    internal class CustomList<T>
    {
        private T[] _arr;
        public int Count { get; private set; }
        public T this[int index]
        {
            get { 
            return _arr[index];
            }
            set {
                _arr[index] = value;
            }

        }
        public int Capacity { get; set; } = 4;

        public CustomList()
        {
            _arr = new T[Capacity];
        }
        public CustomList(int capacity)
        {
            Capacity = capacity;
            _arr=new T[Capacity];
        }

        public void Add(T value)
        {
            if (Count==_arr.Length) 
            {
                Capacity *= 2;
                Array.Resize(ref _arr,Capacity); 
            }
            _arr[Count] = value;
            Count++;

        }

        public override string ToString()
        {

            string str = "{";
            for (int i = 0; i < Count; i++)
            {
                str += _arr[i];
                if (i != Count - 1)
                {
                    str += ", ";
                }
            }
            str+= "}";
            return str;
        }
        public int IndexOf(T value)
        {
            for (int i = 0;i < Count;i++)
            {
                if (_arr[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }
        public int LastIndexOf(T value)
        {
            for (int i = Count-1; 0<= i; i--)
            {
                if (_arr[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public void RemoveAt(int index)
        {
            if (index <Count && index >= 0)
            {
                _arr[index] = default;
            }
        }
        
    }
}
