namespace _02._EightQueens
{
    internal class Program
    {
        static int count = 0;

        static void Main(string[] args)
        {
            int[,] chessboard = new int[8, 8] {
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            PutQueens(0, chessboard);
            Console.WriteLine(count);
        }

        private static void PutQueens(int row, int[,] board)
        {
            if (row >= board.GetLength(0))
            {
                PrintMatrix(board);
                count++;
            }
            else
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col] == 0)
                    {
                        MarkPlaces(board, row, col);
                        PutQueens(row+1, board);
                        UnmarkPlaces(board, row, col);
                    }
                }
            }
        }

        private static void UnmarkPlaces(int[,] board, int row, int col)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                board[row, i]--;
                board[i, col]--;
            }

            int currentRow = row;
            int currentCol = col;

            while (currentRow >= 0 && currentCol >= 0)
            {
                board[currentRow--, currentCol--]--;
            }

            currentRow = row;
            currentCol = col;

            while (currentRow <= 7 && currentCol <= 7)
            {
                board[currentRow++, currentCol++]--;
            }

            currentRow = row;
            currentCol = col;

            while (currentRow >= 0 && currentCol <= 7)
            {
                board[currentRow--, currentCol++]--;
            }

            currentRow = row;
            currentCol = col;

            while (currentRow <= 7 && currentCol >= 0)
            {
                board[currentRow++, currentCol--]--;
            }

            board[row, col] = 0;
        }

        private static void MarkPlaces(int[,] board, int row, int col)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                board[row, i]++;
                board[i, col]++;
            }

            int currentRow = row;
            int currentCol = col;

            while (currentRow >= 0 && currentCol >= 0)
            {
                board[currentRow--, currentCol--]++;
            }

            currentRow = row;
            currentCol = col;

            while (currentRow <= 7 && currentCol <= 7)
            {
                board[currentRow++, currentCol++]++;
            }

            currentRow = row;
            currentCol = col;

            while (currentRow >= 0 && currentCol <= 7)
            {
                board[currentRow--, currentCol++]++;
            }

            currentRow = row;
            currentCol = col;

            while (currentRow <= 7 && currentCol >= 0)
            {
                board[currentRow++, currentCol--]++;
            }

            board[row, col] = -1;
        }

        private static void PrintMatrix(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    switch (board[i, j])
                    {
                        case -1:
                            Console.Write("Q ");
                            break;
                        case 0:
                            Console.Write("- ");
                            break;
                        default:
                            Console.Write("* ");
                            break;
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}