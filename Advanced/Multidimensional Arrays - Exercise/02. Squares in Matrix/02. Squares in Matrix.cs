internal class Program
{
    private static void Main(string[] args)
    {
        int[] rowCol = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = rowCol[0];
        int cols = rowCol[1];

        string[,] matrix = new string[rows, cols];

        FillingMatrix(matrix);
        CountingMatchingGroups(matrix);
    }

    private static void FillingMatrix(string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string[] inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = inputLine[col];
            }
        }
    }

    private static void CountingMatchingGroups(string[,] matrix)
    {
        int matches = 0;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col + 1] && matrix[row, col] == matrix[row + 1, col])
                {
                    matches++;
                }
            }
        }

        PrintingResult(matches);
    }

    private static void PrintingResult(int matches)
    {
        Console.WriteLine(matches);
    }
}