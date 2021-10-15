using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Library
{
    class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = books.ToList();

            IComparer<Book> comparer = new BookComparator();
            this.books.Sort(comparer);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
