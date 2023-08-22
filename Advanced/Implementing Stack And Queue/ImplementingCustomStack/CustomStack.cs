using System.Text;

namespace ImplementingCustomStack;

public class CustomStack
{
    private const int InitialCapacity = 4;
    private int[] items;
    private int count = 0;

    public CustomStack()
    {
        items = new int[InitialCapacity];
    }

    public int Count { get { return count; } }

    public void Push(int element)
    {
        items[count++] = element;

        Resize();
    }

    public int Pop()
    {
        int removedItem = items[count - 1];

        Shrink();
        count--;
        return removedItem;
    }

    public int Peek()
    {
        int itemPeeked = items[count - 1];

        return itemPeeked;
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