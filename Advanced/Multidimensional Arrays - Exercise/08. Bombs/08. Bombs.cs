internal class Program
{
    private static void Main(string[] args)
    {
        int[,] bombLand = FillBombLandFromInput();
        BombCells(bombLand);
        CheckAliveCells(bombLand);
    }
    static int[,] FillBombLandFromInput()
    {
        int rowCol = int.Parse(Console.ReadLine());
        int[,] bombLand = new int[rowCol, rowCol];

        for (int row = 0; row < rowCol; row++)
        {
            int[] inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int col = 0; col < rowCol; col++)
            {
                bombLand[row, col] = inputLine[col];
            }
        }

        return bombLand;
    }

    static void BombCells(int[,] bombLand)
    {
        string[] bombs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < bombs.Length; i++)
        {
            string[] bomb = bombs[i].Split(",", StringSplitOptions.RemoveEmptyEntries);
            int currRow = int.Parse(bomb[0]);
            int currCol = int.Parse(bomb[1]);

            if (bombLand[currRow, currCol] <= 0)
            {
                continue;
            }

            int[] startIndex = GetStartIndex(currRow, currCol);
            int[] endIndex = GetEndIndex(currRow, currCol , bombLand);

            int bombStrength = bombLand[currRow, currCol];
            bombLand[currRow, currCol] = 0;

            for (int row = startIndex[0]; row <= endIndex[0]; row++)
            {
                for (int col = startIndex[1]; col <= endIndex[1]; col++)
                {
                    if (bombLand[row, col] > 0)
                    {
                        bombLand[row, col] -= bombStrength;
                    }
                }
            }
        }
    }

    static int[] GetStartIndex(int currRow, int currCol)
    {
        int[] startIndex = new int[2] { currRow, currCol };

        if (currRow - 1 >= 0)
        {
            startIndex[0] = currRow - 1;
        }

        if (currCol - 1 >= 0)
        {
            startIndex[1] = currCol - 1;
        }

        return startIndex;
    }

    static int[] GetEndIndex(int currRow, int currCol, int[,] bombLand)
    {
        int[] endIndex = new int[2] { currRow, currCol };

        if (currRow + 1 < bombLand.GetLength(0))
        {
            endIndex[0] = currRow + 1;
        }

        if (currCol + 1 < bombLand.GetLength(1))
        {
            endIndex[1] = currCol + 1;
        }

        return endIndex;
    }

    static void CheckAliveCells(int[,] bombLand)
    {
        int sum = 0;
        int aliveCells = 0;

        for (int row = 0; row < bombLand.GetLength(0); row++)
        {
            for (int col = 0; col < bombLand.GetLength(1); col++)
            {
                if (bombLand[row, col] > 0)
                {
                    sum += bombLand[row, col];
                    aliveCells++;
                }
            }
        }

        PrintResult(sum, aliveCells, bombLand);
    }

    static void PrintResult(int sum, int aliveCells, int[,] bombLand)
    {
        Console.WriteLine($"Alive cells: {aliveCells}");
        Console.WriteLine($"Sum: {sum}");

        for (int row = 0; row < bombLand.GetLength(0); row++)
        {
            for (int col = 0; col < bombLand.GetLength(1); col++)
            {
                Console.Write(bombLand[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}