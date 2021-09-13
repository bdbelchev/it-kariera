using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] board = new string[3, 3];

            for (int i = 0; i < 3; i++)
            {
                string[] rowArray = Console.ReadLine().Split(' ').ToArray();

                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = rowArray[j];
                }
            }

            bool horizontalWinX = board[0, 0] == board[0, 1]
                               && board[0, 1] == board[0, 2] && board[0, 2] == "X"
                               || board[1, 0] == board[1, 1]
                               && board[1, 1] == board[1, 2] && board[1, 2] == "X"
                               || board[2, 0] == board[2, 1]
                               && board[2, 1] == board[2, 2] && board[2, 2] == "X";

            bool verticalWinX = board[0, 0] == board[1, 0]
                               && board[1, 0] == board[2, 0] && board[2, 0] == "X"
                               || board[0, 1] == board[1, 1]
                               && board[1, 1] == board[2, 1] && board[2, 1] == "X"
                               || board[0, 2] == board[1, 2]
                               && board[1, 2] == board[2, 2] && board[2, 2] == "X";

            bool diagonalWinX = board[0, 0] == board[1, 1]
                                && board[1, 1] == board[2, 2] && board[2, 2] == "X"
                                || board[0, 2] == board[1, 1]
                                && board[1, 1] == board[2, 0] && board[2, 0] == "X";

            bool horizontalWinO = board[0, 0] == board[0, 1]
                               && board[0, 1] == board[0, 2] && board[0, 2] == "O"
                               || board[1, 0] == board[1, 1]
                               && board[1, 1] == board[1, 2] && board[1, 2] == "O"
                               || board[2, 0] == board[2, 1]
                               && board[2, 1] == board[2, 2] && board[2, 2] == "O";

            bool verticalWinO = board[0, 0] == board[1, 0]
                               && board[1, 0] == board[2, 0] && board[2, 0] == "O"
                               || board[0, 1] == board[1, 1]
                               && board[1, 1] == board[2, 1] && board[2, 1] == "O"
                               || board[0, 2] == board[1, 2]
                               && board[1, 2] == board[2, 2] && board[2, 2] == "O";

            bool diagonalWinO = board[0, 0] == board[1, 1]
                                && board[1, 1] == board[2, 2] && board[2, 2] == "O"
                                || board[0, 2] == board[1, 1]
                                && board[1, 1] == board[2, 0] && board[2, 0] == "O";

            if (horizontalWinX || verticalWinX || diagonalWinX)
            {
                Console.WriteLine("The winner is: X");
            }
            else if (horizontalWinO || verticalWinO || diagonalWinO)
            {
                Console.WriteLine("The winner is: O");
            }
            else
            {
                Console.WriteLine("There is no winner");
            }
        }
    }
}
