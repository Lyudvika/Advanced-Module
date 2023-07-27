int rowCol = int.Parse(Console.ReadLine());
char[,] chessBoard = new char[rowCol, rowCol];

for (int row  = 0; row < rowCol; row++)                                 //filling the chess
{
    string inputLine = Console.ReadLine();

    for (int col = 0; col < rowCol; col++)
    {
        chessBoard[row, col] = inputLine[col];
    }
}

int knightsRemoved = 0;

for (int i = 8; i > 0; i--)
{
    for (int row = 0; row < chessBoard.GetLength(0); row++)                     //starting the chess game
    {
        for (int col = 0; col < chessBoard.GetLength(1); col++)
        {
            if (chessBoard[row, col] != 'K')
            {
                continue;
            }

            int knightsAttacked = 0;

            if (row - 1 >= 0 && col - 2 >= 0)
            {
                if (chessBoard[row - 1, col - 2] == 'K')
                {
                    knightsAttacked++;
                }
            }

            if (row - 2 >= 0 && col - 1 >= 0)
            {
                if (chessBoard[row - 2, col - 1] == 'K')
                {
                    knightsAttacked++;
                }
            }

            if (row - 2 >= 0 && col + 1 < chessBoard.GetLength(1))
            {
                if (chessBoard[row - 2, col + 1] == 'K')
                {
                    knightsAttacked++;
                }
            }

            if (row - 1 >= 0 && col + 2 < chessBoard.GetLength(1))
            {
                if (chessBoard[row - 1, col + 2] == 'K')
                {
                    knightsAttacked++;
                }
            }

            if (row + 1 < chessBoard.GetLength(0) && col - 2 >= 0)
            {
                if (chessBoard[row + 1, col - 2] == 'K')
                {
                    knightsAttacked++;
                }
            }

            if (row + 2 < chessBoard.GetLength(0) && col - 1 >= 0)
            {
                if (chessBoard[row + 2, col - 1] == 'K')
                {
                    knightsAttacked++;
                }
            }

            if (row + 2 < chessBoard.GetLength(0) && col + 1 < chessBoard.GetLength(1))
            {
                if (chessBoard[row + 2, col + 1] == 'K')
                {
                    knightsAttacked++;
                }
            }

            if (row + 1 < chessBoard.GetLength(0) && col + 2 < chessBoard.GetLength(1))
            {
                if (chessBoard[row + 1, col + 2] == 'K')
                {
                    knightsAttacked++;
                }
            }

            if (knightsAttacked == i)
            {
                knightsRemoved++;
                chessBoard[row, col] = '0';
            }
        }
    }
}

Console.WriteLine(knightsRemoved);