using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ColumnMin
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

            int[] minInts = new int[cols];

            for (int i = 0; i < cols; i++)
            {
                int min = int.MaxValue;

                for (int j = 0; j < rows; j++)
                {
                    if (matrix[j, i] < min)
                    {
                        min = matrix[j, i];
                        minInts[i] = matrix[j, i];
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],5}");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < cols; i++)
            {
                Console.Write($"{minInts[i],5}");
            }
        }
    }
}
