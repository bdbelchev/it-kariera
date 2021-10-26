using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _01._BoxOfT
{
    class Box<T>
    {
        private List<T> data;

        public int Count => data.Count;

        public Box()
        {
            data = new List<T>();
        }

        public void Add(T element)
        {
            data.Add(element);
        }

        public T Remove()
        {
            T element = data[Count - 1];
            data.Remove(element);
            return element;
        }
    }
}
