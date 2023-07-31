List<int> numbers = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

Console.WriteLine(numbers.Count);
Console.WriteLine(numbers.Sum());