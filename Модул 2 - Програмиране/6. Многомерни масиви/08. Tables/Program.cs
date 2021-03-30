using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            int sheetCount = int.Parse(Console.ReadLine());
            int[] numsOverAverage = new int[sheetCount];

            for (int i = 0; i < sheetCount; i++)
            {
                int[] matrixDimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int rows = matrixDimensions[0];
                int cols = matrixDimensions[1];
                int[,] table = new int[rows, cols];

                for (int j = 0; j < rows; j++)
                {
                    int[] rowArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                    for (int k = 0; k < cols; k++)
                    {
                        table[j, k] = rowArray[k];
                    }
                }

                int maxNumber = int.MinValue;
                int minNumber = int.MaxValue;
                double average = 0;

                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < cols; k++)
                    {
                        if (table[j, k] > maxNumber)
                        {
                            maxNumber = table[j, k];
                        }

                        if (table[j, k] < minNumber)
                        {
                            minNumber = table[j, k];
                        }

                        average += table[j, k];
                    }
                }

                average /= table.Length;

                Console.WriteLine($"{minNumber} {maxNumber} {average:f2}");

                for (int j = 0; j < rows; j++)
                {
                    for (int k = 0; k < cols; k++)
                    {
                        if (table[j, k] > average)
                        {
                            numsOverAverage[i]++;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numsOverAverage));
        }
    }
}
