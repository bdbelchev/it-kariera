using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DynamicListImplementation
{
    public class DynamicList
    {
        private class Node
        {
            private object element;
            private Node next;

            public object Element
            {
                get { return element; }
                set { element = value; }
            }

            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            public Node(object element, Node prevNode)
            {
                this.element = element;
                prevNode.Next = this;
            }

            public Node(object element)
            {
                this.element = element;
                next = null;
            }
        }

        private Node head;
        private Node tail;
        private int count;

        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void Add(object item)
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

            count++;
        }

        public object Remove(int index)
        {
            object objectToRemove = this[index];

            Node current = head;

            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }

            current.Next = current.Next.Next;

            return objectToRemove;
        }

        public int Remove(object item)
        {
            int indexOfItem = IndexOf(item);

            if (indexOfItem == -1)
            {
                return -1;
            }

            this.Remove(indexOfItem);
            return indexOfItem;
        }

        public int IndexOf(object item)
        {
            Node current = head;

            for (int i = 0; i < count; i++)
            {
                if (current.Element == item)
                {
                    return i;
                }

                current = current.Next;
            }

            return -1;
        }

        public bool Contains(object item)
        {
            return IndexOf(item) != -1;
        }

        public object this[int index]
        {
            get
            {
                if (index >= count)
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
                if (index >= count)
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

        public int Count
        {
            get
            {
                return count;
            }
        }
    }
}
