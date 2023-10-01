namespace Froggy;

public class StartUp
{
    static void Main(string[] args)
    {
        List<int> intputLine = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();
        Lake frog = new(intputLine);

        Console.WriteLine(string.Join(", ", frog));
    }
}