int rows = int.Parse(Console.ReadLine());
int[][] jaggedArray = new int[rows][];

for (int row = 0; row < rows; row++)
{
    jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
}

string command;

while ((command = Console.ReadLine()) != "END")
{
    string[] cmdArg = command.Split();
    string cmdType = cmdArg[0];
    int row = int.Parse(cmdArg[1]);
    int col = int.Parse(cmdArg[2]);
    int value = int.Parse(cmdArg[3]);

    if (row < 0 || col < 0 || row >= rows || col >= jaggedArray[row].Length)
    {
        Console.WriteLine("Invalid coordinates");
        continue;
    }

    if (cmdType == "Add")
    {
        jaggedArray[row][col] += value;
    }
    else if (cmdType == "Subtract")
    {
        jaggedArray[row][col] -= value;
    }
}

for (int row = 0; row < jaggedArray.Length; row++)
{
    for (int col = 0; col < jaggedArray[row].Length; col++)
    {
        Console.Write($"{jaggedArray[row][col]} ");
    }
    Console.WriteLine();
}