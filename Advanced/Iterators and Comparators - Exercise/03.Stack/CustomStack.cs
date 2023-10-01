using System.Collections;

namespace Stack;

public class CustomStack<T> : IEnumerable<T>
{
    private List<T> stack;

    public CustomStack()
    {
        stack = new List<T>();
    }

    public void Push(T element)
    {
        stack.Add(element);
    }

    public void Pop()
    {
        stack.RemoveAt(stack.Count - 1);
    }
    public IEnumerator<T> GetEnumerator()
    {
        for (int i = stack.Count - 1; i >= 0; i--)
        {
            yield return stack[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
