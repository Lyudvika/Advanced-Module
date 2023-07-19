int quantityOfFood = int.Parse(Console.ReadLine());
int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
Queue<int> queueForFood = new Queue<int>(orders);

if (queueForFood.Any())
{
    Console.WriteLine(queueForFood.Max());
}

while (true)
{
    int order = queueForFood.Peek();
    if (quantityOfFood >= order)
    {
        quantityOfFood -= order;
        queueForFood.Dequeue();
    }
    else
    {
        Console.WriteLine($"Orders left: {string.Join(" ", queueForFood)}");
        break;
    }

    if (queueForFood.Count == 0)
    {
        Console.WriteLine("Orders complete");
        break;
    }
}