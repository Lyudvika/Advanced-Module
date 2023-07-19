int pricePerBullet = int.Parse(Console.ReadLine());
int sizeOfGunBarrel =  int.Parse(Console.ReadLine());
int[] inputBullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] inputLocks = Console.ReadLine().Split().Select(int.Parse).ToArray();
int valueOfIntelligence = int.Parse(Console.ReadLine());

Stack<int> bullets = new Stack<int>(inputBullets);
Queue<int> locks = new Queue<int>(inputLocks);
int price = 0;
int shots = 0;

while (bullets.Count > 0 && locks.Count > 0)
{
    shots++;
    price += pricePerBullet;
    int bullet = bullets.Pop();

    if (bullet <= locks.Peek())
    {
        locks.Dequeue();
        Console.WriteLine("Bang!");
    }
    else
    {
        Console.WriteLine("Ping!");
    }

    if (bullets.Count > 0 && shots % sizeOfGunBarrel == 0)
    {
        Console.WriteLine("Reloading!");
    }
}

if (locks.Count == 0)
{
    Console.WriteLine($"{bullets.Count} bullets left. Earned ${valueOfIntelligence - price}");
}
else
{
    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
}