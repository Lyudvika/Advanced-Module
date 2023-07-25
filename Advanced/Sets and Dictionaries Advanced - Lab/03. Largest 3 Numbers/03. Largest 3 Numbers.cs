List<int> nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
int[] sorted = nums.OrderByDescending(x => x).Take(3).ToArray();

Console.WriteLine(string.Join(" ", sorted));