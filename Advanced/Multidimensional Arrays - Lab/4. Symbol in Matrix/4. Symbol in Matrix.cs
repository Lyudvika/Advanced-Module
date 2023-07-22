int size = int.Parse(Console.ReadLine());
int rows = size;
int cols = size;
char[,] matrix = new char[rows, cols];

for (int row = 0; row < rows; row++)
{
    string data = Console.ReadLine();
    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = data[col];
    }
}

char item = char.Parse(Console.ReadLine());
bool isFound = false;

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        if (matrix[row, col] == item)
        {
            isFound = true;
            Console.WriteLine($"({row}, {col})");
            break;
        }
    }
    if (isFound)
    {
        break;
    }
}

if (!isFound)
{
    Console.WriteLine($"{item} does not occur in the matrix");
}