int rowCol = int.Parse(Console.ReadLine());
string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
string[,] matrix = new string[rowCol, rowCol];
int[] minersLocation = new int[2];
int existingCoals = 0;

for (int row = 0; row < rowCol; row++)
{
    string[] inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    for (int col = 0; col < rowCol; col++)
    {
        if (inputLine[col] == "s")
        {
            minersLocation[0] = row;
            minersLocation[1] = col;
        }
        if (inputLine[col] == "c")
        {
            existingCoals++;
        }

        matrix[row, col] = inputLine[col];
    }
}

int coalCollected = 0;

for (int i = 0; i < command.Length; i++)
{
    int[] originalPlace = new int[] { minersLocation[0], minersLocation[1] };
    if (command[i] == "up")
    {
        minersLocation[0]--;
    }
    else if (command[i] == "down")
    {
        minersLocation[0]++;
    }
    else if (command[i] == "left")
    {
        minersLocation[1]--;
    }
    else if (command[i] == "right")
    {
        minersLocation[1]++;
    }

    if (minersLocation[0] < 0 || minersLocation[1] < 0 || minersLocation[0] >= matrix.GetLength(0) || minersLocation[1] >= matrix.GetLength(1))
    {
        minersLocation[0] = originalPlace[0];
        minersLocation[1] = originalPlace[1];
        continue;
    }

    int currRow = minersLocation[0];
    int currCol = minersLocation[1];

    if (matrix[currRow, currCol] == "c")
    {
        coalCollected++;
        matrix[currRow, currCol] = "*";
    }

    if (existingCoals == coalCollected)
    {
        Console.WriteLine($"You collected all coals! ({currRow}, {currCol})");
        break;
    }

    if (matrix[currRow, currCol] == "e")
    {
        Console.WriteLine($"Game over! ({currRow}, {currCol})");
        break;
    }

    if (i == command.Length - 1)
    {
        Console.WriteLine($"{existingCoals - coalCollected} coals left. ({currRow}, {currCol})");
        break;
    }
}