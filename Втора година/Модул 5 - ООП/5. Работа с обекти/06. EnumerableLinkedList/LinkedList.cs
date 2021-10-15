using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._EnumerableLinkedList
{
    class LinkedList<T> : IEnumerable<T>
    {
        private class Node
        {
            public T Element { get; set; }

            public Node Next { get; set; }

            public Node(T element, Node prevNode)
            {
                Element = element;
                prevNode.Next = this;
            }

            public Node(T element)
            {
                Element = element;
                Next = null;
            }
        }

        private Node head;
        private Node tail;

        public LinkedList()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public int Count { get; private set; }

        public void Add(T item)
        {
            if (head == null)
            {
                head = new Node(item);
                tail = head;
            }
            else
            {
                tail = new Node(item, tail);
            }

            Count++;
        }

        public T RemoveAt(int index)
        {
            T objectToRemove = this[index];

            Node current = head;

            if (index == 0)
            {
                head = head.Next;
            }

            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }

            current.Next = current.Next.Next;

            Count--;
            return objectToRemove;
        }

        public int Remove(T item)
        {
            int indexOfItem = IndexOf(item);

            if (indexOfItem == -1)
            {
                return -1;
            }

            RemoveAt(indexOfItem);
            return indexOfItem;
        }

        public int IndexOf(T item)
        {
            Node current = head;

            for (int i = 0; i < Count; i++)
            {
                if (Equals(current.Element, item))
                {
                    return i;
                }

                current = current.Next;
            }

            return -1;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        public T this[int index]
        {
            get
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Node current = head;

                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }

                return current.Element;
            }

            set
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Node current = head;

                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }

                current.Element = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            for (int i = 0; i < Count; i++)
            {
                yield return current.Element;
                current = current.Next;
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
