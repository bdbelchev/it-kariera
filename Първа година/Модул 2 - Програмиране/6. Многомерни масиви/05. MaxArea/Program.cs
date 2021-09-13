using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] rowArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rowArray[j];
                }
            }

            int[,] max2x2 = new int[2, 2];
            int largestSum = 0;

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (currentSum > largestSum)
                    {
                        largestSum = currentSum;
                        max2x2[0, 0] = matrix[i, j];
                        max2x2[0, 1] = matrix[i, j + 1];
                        max2x2[1, 0] = matrix[i + 1, j];
                        max2x2[1, 1] = matrix[i + 1, j + 1];
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{max2x2[i, j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
