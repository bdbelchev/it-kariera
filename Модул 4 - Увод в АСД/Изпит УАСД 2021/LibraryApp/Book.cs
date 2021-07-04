using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Book
    {
        private string id;
        private Book next;

        public Book(string bookId)
        {
            id = bookId;
        }

        public string BookId
        {
            get { return id; }
        }

        public Book Next
        {
            get { return next; }
            set { next = value; }
        }

        public override string ToString()
        {
            return $"Book: {id}";
        }
    }
}
