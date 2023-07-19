Stack<int> numbers = new Stack<int>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int[] cmdArg = Console.ReadLine().Split().Select(int.Parse).ToArray();

    if (cmdArg[0] == 1)
    {
        numbers.Push(cmdArg[1]);
    }
    else if (cmdArg[0] == 2)
    {
        if (numbers.Count > 0)
        {
            numbers.Pop();
        }
    }
    else if (cmdArg[0] == 3) 
    { 
        if (numbers.Any())
        {
            Console.WriteLine(numbers.Max());
        }
    }
    else if (cmdArg[0] == 4)
    {
        if (numbers.Any())
        {
            Console.WriteLine(numbers.Min());
        }
    }
}

Console.WriteLine(string.Join(", ", numbers));