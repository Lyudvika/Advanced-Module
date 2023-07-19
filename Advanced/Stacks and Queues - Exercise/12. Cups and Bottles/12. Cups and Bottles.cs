int[] cups = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] bottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue<int> cupsCapacity = new Queue<int>(cups);
Stack<int> bottleCapacity = new Stack<int>(bottles);

int wastedWater = 0;

while (cupsCapacity.Count > 0 && bottleCapacity.Count > 0)
{
    int cup = cupsCapacity.Dequeue();
    int bottle = bottleCapacity.Pop();

    if (bottle >= cup)
    {
        wastedWater += bottle - cup;
    }
    else
    {
        cup -= bottle;
        while (cup > 0)
        {
            bottle = bottleCapacity.Pop();

            if (bottle - cup > 0)
            {
                wastedWater += bottle - cup;
            }

            cup -= bottle;
        }
    }
}

if (cupsCapacity.Count > 0)
{
    Console.WriteLine($"Cups: {string.Join(" ", cupsCapacity)}");
}
else
{
    Console.WriteLine($"Bottles: {string.Join(" ", bottleCapacity)}");
}

Console.WriteLine($"Wasted litters of water: {wastedWater}");