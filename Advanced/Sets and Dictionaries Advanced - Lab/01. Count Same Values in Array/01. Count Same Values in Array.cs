Dictionary<string, int> occurrences = new Dictionary<string, int>();
string[] nums = Console.ReadLine().Split().ToArray();

for (int i = 0; i < nums.Length; i++)
{
    if (!occurrences.ContainsKey(nums[i]))
    {
        occurrences.Add(nums[i], 0);
    }
    occurrences[nums[i]] += 1;
}

foreach (var item in occurrences)
{
    Console.WriteLine($"{item.Key} - {item.Value} times");
}