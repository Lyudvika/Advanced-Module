using System.Collections;

namespace ListyIterator;

public class ListyIterator<T>
{
    private List<T> list;
    private int index;

    public ListyIterator(List<T> list)
    {
        this.list = list;
    }

    public bool Move()
    {
        if (index < list.Count - 1)
        {
            index++;
            return true;
        }

        return false;
    }

    public bool HasNext()
    {
        return index < list.Count - 1;
    }

    public void Print()
    {
        if (list.Count == 0)
        {
            Console.WriteLine("Invalid Operation!");
            return;
        }

        Console.WriteLine(list[index]);
    }
}