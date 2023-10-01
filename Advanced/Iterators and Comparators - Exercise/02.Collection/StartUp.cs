namespace ListyIterator;

public class StartUp
{
    private const string EndCommand = "END";
    static void Main(string[] args)
    {
        List<string> items = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Skip(1)
            .ToList();
        ListyIterator<string> listyIterator = new(items);

        string command;
        while ((command = Console.ReadLine()) != EndCommand)
        {
            switch (command)
            {
                case "Move":
                    Console.WriteLine(listyIterator.Move());
                    break;
                case "HasNext":
                    Console.WriteLine(listyIterator.HasNext());
                    break;
                case "Print":
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (Exception exeption)
                    {
                        Console.WriteLine(exeption.Message);
                    }
                    break;
                case "PrintAll":
                    foreach (var item in listyIterator)
                    {
                        Console.Write($"{item} ");
                    }
                    Console.WriteLine();
                    break;
            }
        }
    }
}