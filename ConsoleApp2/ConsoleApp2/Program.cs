using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> a = new MyList<int>();
            a.AddItem(6);
            Console.WriteLine("1. Added");
            a.AddItem(6);
            Console.WriteLine("2. Added");
            a.AddItem(6);
            Console.WriteLine("3. Added");
            a.AddItem(6);
            Console.WriteLine("4. Added");
            a.AddItem(6);
            Console.WriteLine("5. Added");
            a.AddItem(6);
            Console.WriteLine("6. Added");
            a.AddItem(6);
            Console.WriteLine("7. Added");
            a.AddItems(6,5,6,7,8);
            Console.WriteLine("Count =>" + a.Count);
        }
    }
    class MyList<T>
    {
        private T[] _arr;
        private int _count;
        public int Count { get => _count; }
        public int Capacity { get; set; } = 0;
        public MyList()
        {
            _count = 0;
            _arr = new T[0];
        }
        public MyList(int capacity)
        {
            Capacity = capacity;
            _count = Capacity;
            _arr = new T[Capacity];
        }
        public void Remove(T input)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i].Equals(input))
                {
                    SlideLeft(i);
                    return;
                }
            }
        }
        private void SlideLeft(int index)
        { //{1,2,4,4,0,0,0,0}
            for (int i = index; i < Count-1; i++)
            {
                _arr[i] = _arr[i + 1];
            }
            _count--;
            _arr[Count] = default;
        }
        public void AddItem(T item)
        {
            Resizeable(_count == _arr.Length);
            _arr[Count] = item;
            _count++;
        }
        public void AddItems(params T[] items)
        {
            foreach (var item in items)
            {
                AddItem(item);
            }
        }
        private void Resizeable(bool b)
        {
            if (b) Array.Resize(ref _arr, (_arr.Length == 0 ? 1 : _arr.Length)*2);
        }
    }
}
