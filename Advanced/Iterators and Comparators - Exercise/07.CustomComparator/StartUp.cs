public class StartUp
{
    private static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Array.Sort(numbers, new CustomSomparator());

        Console.WriteLine(string.Join(" ", numbers));
    }
}

public class CustomSomparator : IComparer<int> 
{
    public int Compare(int x, int y)
    {
        if (x % 2 == 0 && y % 2 != 0)
        {
            return -1;
        }
        else if (x % 2 != 0 && y % 2 == 0)
        {
            return 1;
        }

        return x.CompareTo(y);
    }
}