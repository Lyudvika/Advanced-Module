namespace IteratorsAndComparators;

public class Book : IComparable<Book>
{
    public Book(string title, int year, params string[] authors)
    {
        Title = title;
        Year = year;
        Authors = authors.ToList();
    }

    public string Title { get; private set; }
    public int Year { get; private set; }
    public List<string> Authors { get; private set; }

    public int CompareTo(Book other)
    {
        if (other.Year > Year)
            return -1;

        if (other.Year < Year)
            return 1;

        return Title.CompareTo(other.Title);
    }

    public override string ToString()
    {
        return $"{Title} - {Year}";
    }
}