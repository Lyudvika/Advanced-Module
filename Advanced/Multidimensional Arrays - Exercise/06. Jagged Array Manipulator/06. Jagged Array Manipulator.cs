internal class Program
{
    private static void Main(string[] args)
    {
        int[][] jaggedArray = FillJaggedArray();
        CheckIfLengthOfColumsAreEqual(jaggedArray);
        JaggedArrayManipulation(jaggedArray);
        PrintOnConsole(jaggedArray);
    }
    static int[][] FillJaggedArray()
    {
        int rows = int.Parse(Console.ReadLine());
        int[][] jaggedArray = new int[rows][];

        for (int row = 0; row < rows; row++)
        {
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            jaggedArray[row] = new int[nums.Length];

            for (int col = 0; col < nums.Length; col++)
            {
                jaggedArray[row][col] = nums[col];
            }
        }

        return jaggedArray;
    }
    static void CheckIfLengthOfColumsAreEqual(int[][] jaggedArray)
    {
        for (int row = 0; row < jaggedArray.Length - 1; row++)
        {
            if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] *= 2;
                }
                for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                {
                    jaggedArray[row + 1][col] *= 2;
                }
            }
            else
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] /= 2;
                }
                for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                {
                    jaggedArray[row + 1][col] /= 2;
                }
            }
        }
    }
    static void JaggedArrayManipulation(int[][] jaggedArray)
    {
        string command;
        string endCommand = "End";

        while ((command = Console.ReadLine()) != endCommand)
        {
            string[] cmdArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string cmdType = cmdArg[0];
            int row = int.Parse(cmdArg[1]);
            int column = int.Parse(cmdArg[2]);
            int value = int.Parse(cmdArg[3]);

            if (row < 0 || column < 0 || row >= jaggedArray.Length || column >= jaggedArray[row].Length)
            {
                continue;
            }

            if (cmdType == "Add")
            {
                jaggedArray[row][column] += value;
            }
            else if (cmdType == "Subtract")
            {
                jaggedArray[row][column] -= value;
            }
        }
    }

    static void PrintOnConsole(int[][] jaggedArray)
    {
        for (int row = 0; row < jaggedArray.Length; row++)
        {
            for (int col = 0; col < jaggedArray[row].Length; col++)
            {
                Console.Write(jaggedArray[row][col] + " ");
            }
            Console.WriteLine();
        }
    }
}