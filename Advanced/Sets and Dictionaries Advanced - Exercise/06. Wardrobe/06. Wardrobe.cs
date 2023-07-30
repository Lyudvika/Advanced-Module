Dictionary <string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>(); //color, clothes -> count
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] cmdArg = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
    string color = cmdArg[0];

    if (!wardrobe.ContainsKey(color))
    {
        wardrobe.Add(color, new Dictionary<string, int>());
    }

    for (int c = 1; c < cmdArg.Length; c++)
    {
        if (!wardrobe[color].ContainsKey(cmdArg[c]))
        {
            wardrobe[color].Add(cmdArg[c], 0);
        }

        wardrobe[color][cmdArg[c]]++;
    }
}

string[] clothes = Console.ReadLine().Split();
string colorToSearchFor = clothes[0];
string clotheToSearchFor = clothes[1];

foreach (var color in wardrobe)
{
    Console.WriteLine($"{color.Key} clothes:");

    foreach (var clothe in color.Value)
    {
        Console.Write($"* {clothe.Key} - {clothe.Value}");

        if (colorToSearchFor == color.Key && clotheToSearchFor == clothe.Key)
        {
            Console.Write(" (found!)");
        }
        Console.WriteLine();
    }
}