int[] inputNums = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .Reverse()
    .ToArray();
List<int> endResult = new List<int>();
int n = int.Parse(Console.ReadLine());

Predicate<int> divisible = number => number % n == 0;

for (int i = 0; i < inputNums.Length; i++)
{
    if (!divisible(inputNums[i]))
    {
        endResult.Add(inputNums[i]);
    }
}

Console.WriteLine(string.Join(" ", endResult));