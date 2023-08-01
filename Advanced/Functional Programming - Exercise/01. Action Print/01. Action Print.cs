string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Action<string[]> action = name =>
{
    foreach (string item in names)
    {
        Console.WriteLine(item);
    }
};

action(names);