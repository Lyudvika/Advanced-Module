List<string> input = Console.ReadLine().Split().ToList();
Stack<string> stack = new Stack<string>();

for (int i = input.Count - 1; i >= 0; i--)
{
    stack.Push(input[i]);
}

int sum = 0;
int numOne = int.Parse(stack.Pop());
sum += numOne;

while (stack.Count != 0)
{
    string operation = stack.Pop();
    numOne = int.Parse(stack.Pop());

    switch (operation)
    {
        case "+":
            sum += numOne;
            break;
        case "-":
            sum -= numOne;
            break;
    }
}

Console.WriteLine(sum);