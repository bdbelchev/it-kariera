using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CircularQueue
{
    public class CircularQueue<T>
    {
        private const int DefaultCapacity = 16;

        private T[] elements;
        private int startIndex = 0;
        private int endIndex = 0;

        public int Count { get; private set; }

        public CircularQueue(int capacity = DefaultCapacity)
        {
            elements = new T[capacity];
        }

        public void Enqueue(T element)
        {
            if (this.Count >= elements.Length)
            {
                this.Grow();
            }

            this.elements[endIndex] = element;
            this.endIndex = (this.endIndex + 1) % this.elements.Length;
            this.Count++;
        }

        private void Grow()
        {
            T[] newElements = new T[this.elements.Length * 2];
            this.CopyAllElementsTo(newElements);
            this.elements = newElements;
            this.startIndex = 0;
            this.endIndex = this.Count;
        }

        private void CopyAllElementsTo(T[] resultArr)
        {
            int sourceIndex = this.startIndex;
            int destinationIndex = 0;

            for (int i = 0; i < this.Count; i++)
            {
                resultArr[destinationIndex] = this.elements[sourceIndex];
                sourceIndex = (sourceIndex + 1) % this.elements.Length;
                destinationIndex++;
            }
        }

        public T Dequeue()
        {
            if (this.Count==0)
            {
                throw new InvalidOperationException("The queue is empty!");
            }

            T result = this.elements[startIndex];
            this.startIndex = (this.startIndex + 1) % this.elements.Length;
            this.Count--;
            return result;
        }

        public T[] ToArray()
        {
            T[] resultArray = new T[this.Count];
            CopyAllElementsTo(resultArray);
            return resultArray;
        }
    }
}
