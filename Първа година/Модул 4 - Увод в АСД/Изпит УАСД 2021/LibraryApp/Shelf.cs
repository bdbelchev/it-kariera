using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Shelf
    {
        private Book head;
        private Book tail;
        private int count;

        public Shelf()
        {
            Count = 0;
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        public void AddBook(string bookId)
        {
            Book newBook = new Book(bookId);

            if (this.Count == 0)
            {
                head = tail = newBook;
            }
            else
            {
                tail.Next = newBook;
                tail = newBook;
            }

            Count++;
        }

        public void AddSpecialBook(string bookId)
        {
            Book newBook = new Book(bookId);

            if (this.Count == 0)
            {
                head = tail = newBook;
            }
            else
            {
                Book oldHead = head;
                head = newBook;
                head.Next = oldHead;
            }

            Count++;
        }

        public Book CheckBookIsPresent(string bookId)
        {
            if (Count == 0)
            {
                return null;
            }

            Book currentBook = head;

            while (currentBook.BookId != bookId)
            {
                if (currentBook.Next == null)
                {
                    return null;
                }

                currentBook = currentBook.Next;
            }

            return currentBook;
        }

        public bool ReleaseBook(string bookId)
        {
            if (CheckBookIsPresent(bookId) == null)
            {
                return false;
            }

            if (head.BookId == bookId)
            {
                head = head.Next;
                Count--;
                return true;
            }

            Book currentBook = head;

            while (currentBook.Next.BookId != bookId)
            {
                currentBook = currentBook.Next;
            }

            if (currentBook.Next == tail)
            {
                tail = currentBook;
            }

            currentBook.Next = currentBook.Next.Next;
            Count--;
            return true;
        }

        public bool ReleaseBook(int index)
        {
            if (index < 0 || index > Count - 1)
            {
                return false;
            }

            Book currentBook = head;

            if (index == 0)
            {
                head = head.Next;
                Count--;
                return true;
            }

            for (int i = 0; i < index - 1; i++)
            {
                currentBook = currentBook.Next;
            }

            if (currentBook.Next == tail)
            {
                tail = currentBook;
            }

            currentBook.Next = currentBook.Next.Next;
            Count--;
            return true;
        }

        public StringBuilder ShelfInformation()
        {
            StringBuilder sb = new StringBuilder();

            if (Count == 0)
            {
                sb.Append("Shelf is empty!");
            }
            else
            {
                Book currentBook = head;

                while (currentBook != null)
                {
                    sb.Append(currentBook).AppendLine();
                    currentBook = currentBook.Next;
                }
            }

            return sb;
        }
    }
}
