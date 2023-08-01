int[] inputNumers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Func<int[], int> function = numbers => numbers.Min();

Console.WriteLine(function(inputNumers));