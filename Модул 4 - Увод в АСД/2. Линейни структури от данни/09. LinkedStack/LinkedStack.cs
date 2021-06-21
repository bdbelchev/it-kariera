using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LinkedStack
{
    public class LinkedStack<T>
    {
        private Node<T> firstNode;

        public int Count { get; private set; }

        public void Push(T element)
        {
            this.firstNode = new Node<T>(element, firstNode);
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count < 1)
            {
                throw new InvalidOperationException("Stack cannot be empty!");
            }

            T value = firstNode.Value;
            firstNode = firstNode.NextNode;
            this.Count--;
            return value;
        }

        public T[] ToArray()
        {
            T[] arr = new T[this.Count];

            int index = 0;
            Node<T> currentElement = this.firstNode;

            while (currentElement != null)
            {
                arr[index++] = currentElement.Value;
                currentElement = currentElement.NextNode;
            }

            return arr;
        }

        private class Node<T>
        {
            public T Value { get; private set; }

            public Node<T> NextNode { get; set; }

            public Node(T value, Node<T> nextNode = null)
            {
                this.Value = value;
                this.NextNode = nextNode;
            }
        }
    }
}
