string input = Console.ReadLine();
Stack<char> stack = new Stack<char>();

foreach (char item in input)
{
    if (item == ')' && stack.Any())
    {
        if (stack.Peek() == '(')
        {
            stack.Pop();
        }
        else
        {
            break;
        }
    }
    else if (item == '}' && stack.Any())
    {
        if (stack.Peek() == '{')
        {
            stack.Pop();
        }
        else
        {
            break;
        }
    }
    else if (item == ']' && stack.Any())
    {
        if (stack.Peek() == '[')
        {
            stack.Pop();
        }
        else
        {
            break;
        }
    }
    else
    {
        stack.Push(item);
    }
}

if (stack.Count == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}