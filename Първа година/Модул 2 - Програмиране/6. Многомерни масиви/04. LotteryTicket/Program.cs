using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LotteryTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixDimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = matrixDimensions[0];
            int cols = matrixDimensions[1];
            int[,] ticket = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] rowArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    ticket[i, j] = rowArray[j];
                }
            }

            int mainDiagonalSum = 0;
            int secondDiagonalSum = 0;
            int overDiagonalSum = 0;
            int underDiagonalSum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i == j)
                    {
                        mainDiagonalSum += ticket[i, j];
                    }

                    if (i + j == rows - 1)
                    {
                        secondDiagonalSum += ticket[i, j];
                    }

                    if (i < j)
                    {
                        overDiagonalSum += ticket[i, j];
                    }

                    if (i > j)
                    {
                        underDiagonalSum += ticket[i, j];
                    }
                }
            }

            if (mainDiagonalSum == secondDiagonalSum && overDiagonalSum % 2 == 0 && underDiagonalSum % 2 != 0)
            {
                double prize = 0;
                prize += underDiagonalSum;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (i == j && ticket[i, j] % 2 == 0)
                        {
                            prize += ticket[i, j];
                        }

                        if (ticket[i, j] % 2 == 0 && (i == 0 || i == rows - 1))
                        {
                            prize += ticket[i, j];
                        }

                        if (ticket[i, j] % 2 != 0 && (j == 0 || j == cols - 1))
                        {
                            prize += ticket[i, j];
                        }
                    }
                }

                prize /= 4;

                Console.WriteLine($"YES\nThe amount of money won is: {prize:f2}");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
