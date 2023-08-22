using System.Text;

namespace ImplementingCustomQueue;

public class CustomQueue
{
    private const int InitialCapacity = 4;
    private int[] items;
    private int count = 0;

    public CustomQueue()
    {
        items = new int[InitialCapacity];
    }

    public int Count { get { return count; } }

    public void Enqueue(int element)
    {
        items[count++] = element;

        Resize();
    }

    public int Dequeue()
    {
        int removedItem = items[0];
        Shift();
        Shrink();
        count--;
        return removedItem;
    }

    public int Peek()
    {
        int itemPeeked = items[0];

        return itemPeeked;
    }

    public void Clear()
    {
        items = new int[InitialCapacity];
        count = 0;
    }

    public void ForEach(Action<int> action)
    {
        for (int i = 0; i < count; i++)
        {
            action(items[i]);
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

    private void Shift()
    {
        for (int i = 0; i < items.Length - 1; i++)
        {
            items[i] = items[i + 1];
        }
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