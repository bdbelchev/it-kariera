using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Stack
{
    class Stack<T> : IEnumerable<T>
    {
        private List<T> data;

        public int Index { get; private set; }

        public Stack()
        {
            data = new List<T>();
            Index = -1;
        }

        public void Push(T[] items)
        {
            foreach (T item in items)
            {
                data.Add(item);
                Index++;
            }
        }

        public void Pop()
        {
            if (Index >= 0)
            {
                data.RemoveAt(Index--);
            }
            else
            {
                Console.WriteLine("No elements");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Index; i >= 0; i--)
            {
                yield return data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
