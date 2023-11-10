namespace PlayCatch;

public class Program
{
    private const string Splitter = " ";
    static void Main(string[] args)
    {
        int[] inputNums = Console.ReadLine()
            .Split(Splitter, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int countOfExceptions = 0;
        while (countOfExceptions != 3)
        {
            string[] cmdArg = Console.ReadLine()
                .Split(Splitter, StringSplitOptions.RemoveEmptyEntries);
            string cmdType = cmdArg[0];

            try
            {
                switch (cmdType)
                {
                    case "Replace":
                        ReplaceElement(int.Parse(cmdArg[1]), int.Parse(cmdArg[2]), inputNums);
                        break;
                    case "Print":
                        PrintElements(int.Parse(cmdArg[1]), int.Parse(cmdArg[2]), inputNums);
                        break;
                    case "Show":
                        PrintElements(int.Parse(cmdArg[1]), inputNums);
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("The variable is not in the correct format!");
                countOfExceptions++;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                countOfExceptions++;
            }
        }

        Console.WriteLine(string.Join(", ", inputNums));
    }


    private static void ReplaceElement(int index, int element, int[] numbers)
    {
        if (index < 0 || index >= numbers.Length)
            throw new Exception("The index does not exist!");

        numbers[index] = element;
    }
    private static void PrintElements(int start, int end, int[] numbers)
    {
        if (start < 0 || end >= numbers.Length)
            throw new Exception("The index does not exist!");

        for (int i = start; i < end; i++)
        {
            Console.Write(numbers[i] + ", ");
        }
        Console.Write(numbers[end]);
        Console.WriteLine();
    }
    private static void PrintElements(int index, int[] numbers)
    {
        if (index < 0 || index >= numbers.Length)
            throw new Exception("The index does not exist!");

        Console.WriteLine(numbers[index]);
    }
}