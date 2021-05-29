using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayListImplementation
{
    class ArrayList<T>
    {
        private const int DefaultCapacity = 2;

        private T[] array;

        public ArrayList() : this(DefaultCapacity) { }

        public ArrayList(int capacity)
        {
            this.array = new T[capacity];
        }

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                if (index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.array[index];
            }

            set
            {
                if (index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.array[index] = value;
            }
        }

        public void Add(T item)
        {
            if (this.Count == this.array.Length)
            {
                this.Resize();
            }

            this.array[this.Count++] = item;
        }

        private void Resize()
        {
            T[] newArray = new T[this.array.Length * 2];
            Array.Copy(this.array, newArray, Count);
            this.array = newArray;
        }

        public T RemoveAt(int index)
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            T element = this.array[index];
            this.array[index] = default(T);
            this.Shift(index);
            this.Count--;

            if (this.Count<=this.array.Length/4)
            {
                this.Shrink();
            }

            return element;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count; i++)
            {
                this.array[i] = this.array[i + 1];
            }
        }

        private void Shrink()
        {
            T[] newArray = new T[this.array.Length / 2];
            Array.Copy(this.array, newArray, Count);
            this.array = newArray;
        }
    }
}
