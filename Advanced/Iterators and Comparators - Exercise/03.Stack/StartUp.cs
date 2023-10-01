namespace Stack;

public class StartUp
{
    static void Main(string[] args)
    {
        CustomStack<string> stack = new CustomStack<string>();
        string[] inputLine = Console.ReadLine().Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();
        foreach (string line in inputLine)
        {
            stack.Push(line);
        }

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            inputLine = command.Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries);

            switch (inputLine[0])
            {
                case "Push":
                    foreach (string line in inputLine.Skip(1))
                    {
                        stack.Push(line);
                    }
                    break;
                case "Pop":
                    if (stack.Count() == 0)
                        Console.WriteLine("No elements");
                    else
                        stack.Pop();
                    break;
            }
        }

        for (int i = 0; i < 2; i++)
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}