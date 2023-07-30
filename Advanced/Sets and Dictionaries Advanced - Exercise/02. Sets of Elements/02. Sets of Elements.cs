HashSet<int> setOne = new HashSet<int>();
HashSet<int> setTwo = new HashSet<int>();
int[] length = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int setOneLength = length[0];
int setTwoLength = length[1];

for (int i = 0; i < setOneLength; i++)
{
    int num = int.Parse(Console.ReadLine());
    setOne.Add(num);
}

for (int i = 0; i < setTwoLength; i++)
{
    int num = int.Parse(Console.ReadLine());
    setTwo.Add(num);
}

setOne.IntersectWith(setTwo);

Console.WriteLine(string.Join(" ", setOne));