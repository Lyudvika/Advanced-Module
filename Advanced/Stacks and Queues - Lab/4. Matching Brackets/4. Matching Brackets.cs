string input = Console.ReadLine();
Stack<int> expressions = new Stack<int>();
int index = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '(')
    {
        expressions.Push(index);
    }
    else if (input[i] == ')')
    {
        int startIndex = expressions.Pop();
        for (int k = startIndex; k <= index; k++)
        {
            Console.Write(input[k]);
        }
        Console.WriteLine();
    }
    index++;
}