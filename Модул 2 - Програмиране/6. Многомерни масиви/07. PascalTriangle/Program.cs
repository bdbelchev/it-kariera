using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int[][] triangle = new int[h][];

            for (int row = 0; row < h; row++)
            {
                triangle[row] = new int[row + 1];
            }

            triangle[0][0] = 1;

            for (int row = 0; row < h - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            int spacesCount = h;

            for (int i = 0; i < h; i++)
            {
                Console.Write(new string(' ', spacesCount--));

                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{triangle[i][j],2}");
                }

                Console.WriteLine();
            }
        }
    }
}
