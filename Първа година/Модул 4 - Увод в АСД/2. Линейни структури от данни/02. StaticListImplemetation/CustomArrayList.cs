using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StaticListImplemetation
{
    public class CustomArrayList
    {
        private object[] arr;

        private int count;

        public int Count
        {
            get
            {
                return count;
            }
        }

        private static readonly int INITIAL_CAPACITY = 4;

        public CustomArrayList()
        {
            arr = new object[INITIAL_CAPACITY];
            count = 0;
        }
        public void Add(object item)
        {
            if (this.count >= this.arr.Length)
            {
                this.Resize();
            }

            arr[count++] = item;
        }

        private void Resize()
        {
            object[] newArr = new object[arr.Length * 2];
            Array.Copy(arr, newArr, count);
            arr = newArr;
        }

        public void Insert(int index, object item)
        {
            if (this.count >= this.arr.Length)
            {
                this.Resize();
            }

            this.ShiftRight(index);
            arr[index] = item;
            count++;
        }

        private void ShiftRight(int index)
        {
            for (int i = this.count; i > index; i--)
            {
                arr[i] = arr[i - 1];
            }
        }

        private void ShiftLeft(int index)
        {
            for (int i = index; i < this.count; i++)
            {
                arr[i] = arr[i + 1];
            }
        }

        public int IndexOf(object item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }

        public void Clear()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = default;
            }

            this.count = 0;
        }

        public bool Contains(object item)
        {
            return this.arr.Any(obj => obj == item);
        }

        public object this[int index]
        {
            get
            {
                if (index >= this.arr.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.arr[index];
            }

            set
            {
                if (index >= this.arr.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.arr[index] = value;
            }
        }

        public object Remove(int index)
        {
            if (index >= this.count)
            {
                throw new ArgumentOutOfRangeException();
            }

            object element = arr[index];
            arr[index] = default;
            this.ShiftLeft(index);
            this.count--;
            return element;
        }

        public int Remove(object item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == item)
                {
                    this.Remove(i);
                    return i;
                }
            }

            return -1;
        }
    }
}
