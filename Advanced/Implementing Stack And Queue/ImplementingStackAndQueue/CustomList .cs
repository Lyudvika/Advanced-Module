using System.Text;

namespace ImplementingCustomList;

public class CustomList
{
    //fields
    private const int InitialCapacity = 2;
    private int[] items;
    private int count = 0;

    //constructors
    public CustomList()
    {
        items = new int[InitialCapacity];
    }

    //properties
    public int Count { get { return count; } }

    //methods
    public void Add(int element)
    {
        items[count++] = element;

        Resize();
    }

    public void Insert(int index, int element)
    {
        if (IndexValidation(index))
        {
            int oldItem = items[index];
            items[index] = element;
            items[index + 1] = oldItem;
            count++;

            Resize();
        }
    }

    public int RemoveAt(int index)
    {
        if (IndexValidation(index))
        {
            int removedItem = items[index];
            Shift(index);
            Shrink();
            count--;
            return removedItem;
        }

        return -1;
    }

    public bool Contains(int element)
    {
        for (int i = 0; i < count; i++)
        {
            if (items[i] == element)
            {
                return true;
            }
        }

        return false;
    }

    public void Swap(int firstIndex, int secondIndex)
    {
        if (IndexValidation(firstIndex) && IndexValidation(secondIndex))
        {
            int firstElement = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = firstElement;
        }
    }

    private void Resize()
    {
        if (count == items.Length)
        {
            int[] newItems = new int[count * 2];
            for (int i = 0; i < count; i++)
            {
                newItems[i] = items[i];
            }

            items = newItems;
        }
    }

    private void Shrink()
    {
        if (count == items.Length / 2)
        {
            int[] newItems = new int[count];
            for (int i = 0; i < count; i++)
            {
                newItems[i] = items[i];
            }

            items = newItems;
        }
    }

    private void Shift(int index)
    {
        for (int i = index; i < items.Length - 1; i++)
        {
            items[i] = items[i + 1];
        }
    }

    private bool IndexValidation(int index)
    {
        if (index >= items.Length)
        {
            Console.WriteLine("Invalid index.");
            return false;
        }

        return true;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            stringBuilder.Append(items[i] + " ");
        }
        return stringBuilder.ToString();
    }
}