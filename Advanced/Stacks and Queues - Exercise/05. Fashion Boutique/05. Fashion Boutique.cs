int[] clothesInBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
int capacityOfRack = int.Parse(Console.ReadLine());

Stack<int> boxes = new Stack<int>(clothesInBox);
int sumOfClothes = 0;
int racksUsed = 1;

while (boxes.Count > 0)
{
    sumOfClothes += boxes.Peek();
    if (sumOfClothes > capacityOfRack)
    {
        sumOfClothes = 0;
        racksUsed++;
    }
    else 
    { 
        boxes.Pop();
    }
}

Console.WriteLine(racksUsed);