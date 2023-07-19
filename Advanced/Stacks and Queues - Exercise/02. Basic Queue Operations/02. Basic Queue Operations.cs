int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

int elementsToQueue = input[0];
int elementsToRemove = input[1];
int elementToLookFor = input[2];
Queue<int> queue = new Queue<int>(elementsToQueue);

for (int i = 0; i < elementsToQueue; i++)
{
    queue.Enqueue(elements[i]);
}

for (int i = 0; i < elementsToRemove; i++)
{
    if (queue.Count > 0)
    {
        queue.Dequeue();
    }
}

if (queue.Contains(elementToLookFor))
{
    Console.WriteLine("true");
}
else
{
    if (queue.Count > 0)
    {
        Console.WriteLine(queue.Min());
    }
    else
    {
        Console.WriteLine(queue.Count);
    }
}