int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> evenNum = new Queue<int>(numbers);
int numOfLoops = evenNum.Count;

for (int i = 0; i < numOfLoops; i++)
{
    int num = evenNum.Dequeue();
    if (num % 2 == 0)
    {
        evenNum.Enqueue(num);
    }
}

Console.WriteLine(string.Join(", ", evenNum));