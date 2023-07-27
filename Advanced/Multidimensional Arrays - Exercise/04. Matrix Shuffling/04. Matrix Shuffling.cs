internal class Program
{
    private static void Main(string[] args)
    {
        int[] rowCol = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = rowCol[0];
        int cols = rowCol[1];

        int[,] matrix = new int[rows, cols];

        FillingMatrix(matrix);
        SwappingRowsAndCols(matrix);
    }

    private static void FillingMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = inputLine[col];
            }
        }
    }

    private static void SwappingRowsAndCols(int[,] matrix)
    {
        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] cmdArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (cmdArg.Length != 5 || cmdArg[0] != "swap")
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            int rowOne = int.Parse(cmdArg[1]);
            int colOne = int.Parse(cmdArg[2]);
            int rowTwo = int.Parse(cmdArg[3]);
            int colTwo = int.Parse(cmdArg[4]);

            if (rowOne < 0 || rowOne > matrix.GetLength(0) ||
                rowTwo < 0 || rowTwo > matrix.GetLength(0) ||
                colOne < 0 || colOne > matrix.GetLength(1) ||
                colTwo < 0 || colTwo > matrix.GetLength(1))
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            int firstNum = matrix[rowOne, colOne];
            matrix[rowOne, colOne] = matrix[rowTwo, colTwo];
            matrix[rowTwo, colTwo] = firstNum;

            PrintingResult(matrix);
        }
    }

    private static void PrintingResult(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}