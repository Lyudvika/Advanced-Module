internal class Program
{
    private static void Main(string[] args)
    {
        int[] rowsCols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = rowsCols[0];
        int cols = rowsCols[1];

        string[,] snakePath = new string[rows, cols];
        string snake = Console.ReadLine();

        FolloingSnakePath(snakePath, snake);
        PrintingResult(snakePath);
    }

    private static void FolloingSnakePath(string[,] snakePath, string snake)
    {
        int index = 0;

        for (int row = 0; row < snakePath.GetLength(0); row++)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < snakePath.GetLength(1); col++)
                {
                    snakePath[row, col] = snake[index++].ToString();

                    if (index >= snake.Length)
                    {
                        index = 0;
                    }
                }
            }
            else
            {
                for (int col = snakePath.GetLength(1) - 1; col >= 0; col--)
                {
                    snakePath[row, col] = snake[index++].ToString();

                    if (index >= snake.Length)
                    {
                        index = 0;
                    }
                }
            }
        }
    }

    private static void PrintingResult(string[,] snakePath)
    {
        for (int row = 0; row < snakePath.GetLength(0); row++)
        {
            for (int col = 0; col < snakePath.GetLength(1); col++)
            {
                Console.Write(snakePath[row, col]);
            }
            Console.WriteLine();
        }
    }
}