using System.Text;

namespace BoxOfInteger;
public class Box<T>
{
    private List<T> values;

    public Box()
    {
        values = new List<T>();
    }

    public void Add(T value)
    {
        values.Add(value);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        foreach (T item in values)
        {
            sb.AppendLine($"{typeof(T)}: {item}");
        }

        return sb.ToString().TrimEnd();
    }
}