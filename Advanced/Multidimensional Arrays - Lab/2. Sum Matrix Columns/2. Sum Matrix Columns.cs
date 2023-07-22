int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int rows = input[0];
int cols = input[1];

int[,] matrix = new int[rows, cols];

for (int r = 0; r < rows; r++)
{
    int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    for (int c = 0; c < cols; c++)
    {
        matrix[r, c] = nums[c];
    }
}

int sum = 0;

for (int c = 0; c < cols; c++)
{
    int currCol = 0;
    for (int r = 0; r < rows; r++)
    {
        currCol += matrix[r, c];
    }
    Console.WriteLine(currCol);