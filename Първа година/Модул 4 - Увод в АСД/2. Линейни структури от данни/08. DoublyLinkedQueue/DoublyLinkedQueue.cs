using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.DoublyLinkedQueue
{
    public class DoublyLinkedQueue<T>
    {
        private QueueNode<T> head;
        private QueueNode<T> tail;

        public int Count { get; private set; }

        public void Enqueue(T element)
        {
            if (this.Count < 1)
            {
                this.head = this.tail = new QueueNode<T>(element);
            }
            else
            {
                var newTail = new QueueNode<T>(element);
                this.tail.NextNode = newTail;
                newTail.PrevNode = this.tail;
                this.tail = newTail;
            }

            this.Count++;
        }

        public T Dequeue()
        {
            if (Count < 1)
            {
                throw new InvalidOperationException("Queue cannot be empty!");
            }

            T valueToReturn = this.head.Value;
            this.head = this.head.NextNode;
            this.head.PrevNode = null;
            this.Count--;
            return valueToReturn;
        }

        public T[] ToArray()
        {
            T[] arr = new T[this.Count];

            int index = 0;
            var currentNode = this.head;

            while (currentNode != null)
            {
                arr[index++] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }

            return arr;
        }

        private class QueueNode<T>
        {
            public T Value { get; private set; }
            public QueueNode<T> NextNode { get; set; }
            public QueueNode<T> PrevNode { get; set; }

            public QueueNode(T value)
            {
                this.Value = value;
            }
        }
    }
}