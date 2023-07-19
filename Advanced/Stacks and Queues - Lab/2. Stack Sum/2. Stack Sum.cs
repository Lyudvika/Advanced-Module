List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
Stack<int> stack = new Stack<int>(numbers);
string input;

while ((input = Console.ReadLine().ToLower()) != "end")
{
    string[] cmdArd = input.ToLower().Split();
    string cmdType = cmdArd[0];

    if (cmdType == "add")
    {
        int numOne = int.Parse(cmdArd[1]);
        int numTwo = int.Parse(cmdArd[2]);
        stack.Push(numOne);
        stack.Push(numTwo);
    }
    else if (cmdType == "remove")
    {
        int n = int.Parse(cmdArd[1]);
        if (stack.Count > n)
        {
            for (int i = 0; i < n; i++)
            {
                stack.Pop();
            }
        }
    }
}

int sum = 0;

while (stack.Count != 0)
{
    sum += stack.Pop();
}
Console.WriteLine($"Sum: {sum}");