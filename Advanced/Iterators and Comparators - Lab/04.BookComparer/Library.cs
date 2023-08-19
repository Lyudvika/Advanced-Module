using System.Collections;

namespace IteratorsAndComparators;

public class Library : IEnumerable<Book>
{
    public Library(params Book[] books)
    {
        Books = books.ToList();
    }

    public List<Book> Books { get; set; }

    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(Books);
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private class LibraryIterator : IEnumerator<Book>
    {
        private List<Book> books;
        private int currIndex = -1;

        public LibraryIterator(List<Book> books)
        {
            this.books = books;
            books.Sort(new BookComparator());
        }

        public Book Current => books[currIndex];

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            return ++currIndex < books.Count;
        }

        public void Reset()
        {
            currIndex = -1;
        }
    }
}