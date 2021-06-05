using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ArrayStack
{
    public class ArrayStack<T>
    {
        private T[] elements;

        public int Count { get; private set; }

        private const int InitialCapacity = 16;

        public ArrayStack(int capacity = InitialCapacity)
        {
            this.elements = new T[capacity];
        }

        public void Push(T element)
        {
            if (this.Count >= this.elements.Length)
            {
                this.Grow();
            }

            this.elements[this.Count++] = element;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack cannot be empty!");
            }

            return this.elements[this.Count--];
        }

        public T[] ToArray()
        {
            T[] returnArray = new T[this.Count];

            for (int i = 0; i < this.Count; i++)
            {
                returnArray[i] = this.elements[i];
            }

            return returnArray;
        }

        private void Grow()
        {
            T[] newElements = new T[this.elements.Length * 2];

            for (int i = 0; i < this.Count; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
        }
    }
}
