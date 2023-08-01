string[] inputNames = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

Action<string[]> printer = names =>
{
    foreach (string name in names)
    {
        Console.WriteLine("Sir " + name);
    }
};

printer(inputNames);