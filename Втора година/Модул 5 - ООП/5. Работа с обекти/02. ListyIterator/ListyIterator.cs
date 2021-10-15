using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._ListyIterator
{
    class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> data;
        private int index;

        public ListyIterator(params T[] data)
        {
            index = 0;
            this.data = data.ToList();
        }

        public bool Move()
        {
            if (!HasNext())
            {
                return false;
            }

            index++;
            return true;
        }

        public bool HasNext()
        {
            return index + 1 < data.Count;
        }

        public void Print()
        {
            if (data.Count > 0)
            {
                Console.WriteLine(data[index]);
            }
            else
            {
                Console.WriteLine("Invalid Operation!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T t in data)
            {
                yield return t;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
