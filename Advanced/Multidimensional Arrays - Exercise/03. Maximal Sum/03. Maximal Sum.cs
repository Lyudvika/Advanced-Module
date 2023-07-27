internal class Program
{
    private static void Main(string[] args)
    {
        int[] rowCol = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = rowCol[0];
        int cols = rowCol[1];

        int[,] matrix = new int[rows, cols];

        FillingMatrix(matrix);
        GettingTheMaxSumFromASquare(matrix);
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

    private static void GettingTheMaxSumFromASquare(int[,] matrix)
    {
        int maxSum = 0;
        int maxRow = 0;
        int maxCol = 0;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int rowOneSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2];
                int rowTwoSum = matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2];
                int rowThreeSum = matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                int currSum = rowOneSum + rowTwoSum + rowThreeSum;

                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    maxRow = row;
                    maxCol = col;
                }
            }
        }

        PrintingResult(matrix, maxSum, maxRow, maxCol);
    }

    private static void PrintingResult(int[,] matrix,int sum, int maxRow, int maxCol)
    {
        Console.WriteLine("Sum = " + sum);

        for (int row = maxRow; row < maxRow + 3; row++)
        {
            for (int col = maxCol; col < maxCol + 3; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}