HashSet<string> elements =  new HashSet<string>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] elementsName = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    foreach (string element in elementsName)
    {
        elements.Add(element);
    }
}

Console.WriteLine(string.Join(" ", elements.OrderBy(x => x)));