List<string> input = Console.ReadLine().Split().ToList();
int trow = int.Parse(Console.ReadLine());
Queue<string> children = new Queue<string>(input);

while (children.Count != 1)
{
    for (int i = 1; i < trow; i++)
    {
        string child = children.Dequeue();
        children.Enqueue(child);
    }
    Console.WriteLine($"Removed {children.Dequeue()}");
}

Console.WriteLine($"Last is {children.Dequeue()}");