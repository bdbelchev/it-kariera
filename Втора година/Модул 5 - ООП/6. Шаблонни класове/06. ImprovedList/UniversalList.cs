using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace _06._ImprovedList
{
    class UniversalList<T> : IEnumerable<T> where T : IComparable<T>
    {
        private List<T> data;

        public UniversalList()
        {
            data = new List<T>();
        }

        public void Add(T element)
        {
            data.Add(element);
        }

        public T Remove(int index)
        {
            T element = data[index];
            data.RemoveAt(index);
            return element;
        }

        public bool Contains(T element)
        {
            return data.Contains(element);
        }

        public void Swap(int i1, int i2)
        {
            T temp = data[i1];
            data[i1] = data[i2];
            data[i2] = temp;
        }

        public int CountGreaterThan(T element)
        {
            return data.Count(current => current.CompareTo(element) > 0);
        }

        public T Max()
        {
            return data.Max();
        }

        public T Min()
        {
            return data.Min();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
