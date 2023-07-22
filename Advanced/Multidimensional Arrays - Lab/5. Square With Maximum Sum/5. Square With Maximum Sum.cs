int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = size[0];
int cols = size[1];
int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = input[col];
    }
}

int maxSum = 0;
int maxRow = 0;
int maxCol = 0;

for (int row = 0; row < rows - 1; row++)
{
    for (int col = 0; col < cols - 1; col++)
    {
        int currSum = 0;
        currSum += matrix[row, col];
        currSum += matrix[row, col + 1];
        currSum += matrix[row + 1, col];
        currSum += matrix[row + 1, col + 1];

        if (currSum > maxSum)
        {
            maxSum = currSum;
            maxRow = row;
            maxCol = col;
        }
    }
}

Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
Console.WriteLine(maxSum);