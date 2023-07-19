int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

int elementsToStack = input[0];
int elementsToRemove = input[1];
int elementToLookFor = input[2];
Stack<int> stack = new Stack<int>(elementsToStack);

for (int i = 0; i < elementsToStack; i++)
{
    stack.Push(elements[i]);
}

for (int i = 0; i < elementsToRemove; i++)
{
    if (stack.Count > 0)
    {
        stack.Pop();
    }
}

if (stack.Contains(elementToLookFor))
{
    Console.WriteLine("true");
}
else
{
    if (stack.Count > 0)
    {
        Console.WriteLine(stack.Min());
    }
    else
    {
        Console.WriteLine(stack.Count);
    }
}