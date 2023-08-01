int nameLength = int.Parse(Console.ReadLine());
List<string> inputNames = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

Predicate<string> isNameValid = name => name.Length <= nameLength;

foreach (string name in inputNames)
{
    if (isNameValid(name))
    {
        Console.WriteLine(name);
    }
}