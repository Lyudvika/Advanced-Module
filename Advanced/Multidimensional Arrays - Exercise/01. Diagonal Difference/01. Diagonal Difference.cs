int rowCol = int.Parse(Console.ReadLine());
int[,] matrix = new int[rowCol, rowCol];

for (int row = 0; row < rowCol; row++)
{
    int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int col = 0; col < rowCol; col++)
    {
        matrix[row, col] = input[col];
    }
}

int primaryDiagonalSum = 0;
int secondaryDiagonalSum = 0;

for (int i = 0; i < rowCol; i++)
{
    primaryDiagonalSum += matrix[i, i];
}

for (int i = 0; i < rowCol; i++)
{
    secondaryDiagonalSum += matrix[rowCol - i - 1, i];
}
double result = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);

Console.WriteLine(result);