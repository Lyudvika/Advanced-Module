int[] rowCol = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
int rows = rowCol[0];
int cols = rowCol[1];
char[,] bunnyLair = new char[rows, cols];       //matrix in which we are playing the game
int[] playerPosition = new int[2];              //start position of the player in the game

for (int row = 0; row < rows; row++)            //filling the bunny lair
{
    string inputLine = Console.ReadLine();

    for (int col = 0; col < cols; col++)
    {
        if (inputLine[col] == 'P')              //checking where the player is at
        {
            playerPosition[0] = row;
            playerPosition[1] = col;
        }

        bunnyLair[row, col] = inputLine[col];
    }
}

string playerMoves = Console.ReadLine();        //reading from input the moves that the player is making (U, D, L, R)
int playerRow = playerPosition[0];              //in which row player is located
int playerCol = playerPosition[1];              //in which col player is located
bool playerWon = false;                         //the player has won
bool playerDied = false;                        //the player has died

for (int move = 0; move < playerMoves.Length; move++)   //starting the game
{
    playerPosition[0] = playerRow;
    playerPosition[1] = playerCol;

    if (playerMoves[move] == 'U')                       //player goes up (row - 1)
    {
        playerRow--;
    }
    else if (playerMoves[move] == 'D')                  //player goes down (row + 1)
    {
        playerRow++;
    }
    else if (playerMoves[move] == 'L')                  //player goes left (col - 1)
    {
        playerCol--;
    }
    else if (playerMoves[move] == 'R')                  //player goes right (col + 1)
    {
        playerCol++;
    }

    if (playerRow < 0 || playerCol < 0 || playerRow >= bunnyLair.GetLength(0) || playerCol >= bunnyLair.GetLength(1))
    {
        playerWon = true;
        bunnyLair[playerPosition[0], playerPosition[1]] = '.';
        playerRow = playerPosition[0];
        playerCol = playerPosition[1];
    }
    else if (bunnyLair[playerRow, playerCol] == 'B')
    {
        playerDied = true;
    }
    else
    {
        bunnyLair[playerPosition[0], playerPosition[1]] = '.';
        bunnyLair[playerRow, playerCol] = 'P';
    }

    List<int> bunniesPosition = new List<int>();        //geting the positions of all the bunnies

    for (int row = 0; row < bunnyLair.GetLength(0); row++)
    {
        for (int col = 0; col < bunnyLair.GetLength(1); col++)
        {
            if (bunnyLair[row, col] == 'B')
            {
                bunniesPosition.Add(row);
                bunniesPosition.Add(col);
            }
        }
    }

    for (int i = 0; i < bunniesPosition.Count; i += 2)            //the bunnies spread up, down, left, right
    {
        int bunnyRow = bunniesPosition[i];
        int bunnyCol = bunniesPosition[i + 1];

        if (bunnyRow - 1 >= 0)                                  //add bunny up
        {
            if (bunnyLair[bunnyRow - 1, bunnyCol] == 'P')       //if player has been found, he dies
            {
                playerDied = true;
            }

            bunnyLair[bunnyRow - 1, bunnyCol] = 'B';            //replacing the place with a new bunny
        }

        if (bunnyRow + 1 < bunnyLair.GetLength(0))              //add bunny down
        {
            if (bunnyLair[bunnyRow + 1, bunnyCol] == 'P')
            {
                playerDied = true;
            }

            bunnyLair[bunnyRow + 1, bunnyCol] = 'B';
        }

        if (bunnyCol - 1 >= 0)                                  //add bunny left
        {
            if (bunnyLair[bunnyRow, bunnyCol - 1] == 'P')
            {
                playerDied = true;
            }

            bunnyLair[bunnyRow, bunnyCol - 1] = 'B';
        }

        if (bunnyCol + 1 < bunnyLair.GetLength(1))              //add bunny right
        {
            if (bunnyLair[bunnyRow, bunnyCol + 1] == 'P')
            {
                playerDied = true;
            }

            bunnyLair[bunnyRow, bunnyCol + 1] = 'B';
        }
    }

    if (playerDied || playerWon)
    {
        break;
    }
}

for (int row = 0; row < bunnyLair.GetLength(0); row++)
{
    for (int col = 0; col < bunnyLair.GetLength(1); col++)
    {
        Console.Write(bunnyLair[row, col]);
    }

    Console.WriteLine();
}

if (playerWon)
{
    Console.WriteLine($"won: {playerRow} {playerCol}");
}
else
{
    Console.WriteLine($"dead: {playerRow} {playerCol}");
}