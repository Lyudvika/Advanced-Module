using System.Collections;

namespace Froggy;

public class Lake : IEnumerable<int>
{
    private List<int> list;

    public Lake(List<int> input)
    {
        list = input;
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < list.Count; i += 2)
        {
            yield return list[i];
        }

        int secondStart = 0;
        if (list.Count % 2 == 1)
            secondStart = list.Count - 2;
        else
            secondStart = list.Count - 1;

        for (int i = secondStart; i >= 0; i -= 2)
        {
            yield return list[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}