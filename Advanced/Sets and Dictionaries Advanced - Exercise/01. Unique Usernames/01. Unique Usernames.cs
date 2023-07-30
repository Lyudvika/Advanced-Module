HashSet<string> uniqueNames = new HashSet<string>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    uniqueNames.Add(name);
}

Console.WriteLine(string.Join(System.Environment.NewLine, uniqueNames));