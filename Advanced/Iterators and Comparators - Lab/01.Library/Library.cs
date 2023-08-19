﻿using System.Collections;

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
        return Books.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}