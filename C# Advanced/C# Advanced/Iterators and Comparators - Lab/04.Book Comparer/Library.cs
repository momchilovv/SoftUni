using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            this.Books = new List<Book>(books);
        }

        public List<Book> Books { get; private set; }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.Books);
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private class LibraryIterator : IEnumerator<Book>
        {
            private int currentIndex = -1;
            private readonly List<Book> books;

            public LibraryIterator(List<Book> books)
            {
                this.books = books.OrderBy(t => t.Title).ToList();
            }

            public Book Current => this.books[currentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose() { }

            public bool MoveNext()
            {
                this.currentIndex++;
                if (this.currentIndex >= this.books.Count)
                {
                    return false;
                }

                return true;
            }

            public void Reset()
            {
                this.currentIndex = -1;
            }
        }
    }
}