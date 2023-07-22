int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = input[0];
int cols = input[1];

int[,] matrix = new int[rows, cols];

for (int r = 0; r < rows; r++)
{
    int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
    for (int c = 0; c < cols; c++)
    {
        matrix[r, c] = nums[c];
    }
}

int sum = 0;

for (int r = 0; r < rows; r++)
{
    for (int c = 0; c < cols; c++)
    {
        sum += matrix[r, c];
    }
}

Console.WriteLine(rows);
Console.WriteLine(cols);
Console.WriteLine(sum);