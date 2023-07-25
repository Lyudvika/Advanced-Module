var worldInfo = new Dictionary<string, Dictionary<string, List<string>>>(); //continents -> countries, cities
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string continent = cmdArg[0];
    string country = cmdArg[1];
    string city = cmdArg[2];

    if (!worldInfo.ContainsKey(continent))
    {
        worldInfo.Add(continent, new Dictionary<string, List<string>>());
        //worldInfo[continent].Add(country, new List<string>());
    }
    if (!worldInfo[continent].ContainsKey(country))
    {
        worldInfo[continent].Add(country, new List<string>());
    }

    worldInfo[continent][country].Add(city);
}

foreach (var continent in worldInfo)
{
    Console.WriteLine($"{continent.Key}:");
    foreach (var county in continent.Value)
    {
        Console.WriteLine($"  {county.Key} -> {string.Join(", ", county.Value)}");
    }
}