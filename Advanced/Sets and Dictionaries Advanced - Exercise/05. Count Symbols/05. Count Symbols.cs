Dictionary<char, int> frequency = new Dictionary<char, int>();
string text = Console.ReadLine();

for (int i = 0; i < text.Length; i++)
{
    if (!frequency.ContainsKey(text[i]))
    {
        frequency.Add(text[i], 0);
    }
    frequency[text[i]]++;
}

foreach (var item in frequency.OrderBy(x => x.Key))
{
    Console.WriteLine($"{item.Key}: {item.Value} time/s");
}