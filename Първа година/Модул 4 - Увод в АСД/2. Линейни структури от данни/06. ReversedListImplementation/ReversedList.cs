using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _06.ReversedListImplementation
{
    public class ReversedList<T>
    {
        private const int DefaultCapacity = 2;

        private T[] elements;
        private T[] reverseElements;

        public int Count { get; private set; }

        public ReversedList(int capacity = DefaultCapacity)
        {
            this.elements = new T[capacity];
        }

        public int Capacity
        {
            get
            {
                return this.elements.Length;
            }
        }

        public T this[int index]
        {
            get
            {
                return this.reverseElements[index];
            }
        }

        public void Add(T item)
        {
            if (this.Count >= Capacity)
            {
                this.Grow();
            }

            this.elements[this.Count++] = item;
            this.reverseElements = this.elements.Reverse().ToArray();
        }

        private void Grow()
        {
            T[] newElements = new T[Capacity * 2];
            this.elements.CopyTo(newElements, 0);
            this.elements = newElements;
        }

        public void RemoveAt(int index)
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("List cannot be empty.");
            }

            this.Shift(index);
            this.elements = this.reverseElements.Reverse().ToArray();
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count; i++)
            {
                this.reverseElements[i] = this.reverseElements[i + 1];
            }

            this.reverseElements[Count--] = default(T);
        }
    }
}
