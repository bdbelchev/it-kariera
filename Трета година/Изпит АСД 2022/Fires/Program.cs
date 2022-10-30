using System;
using System.Collections.Generic;
using System.Linq;

namespace Fires
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[,] matrix = new int[dimensions[0], dimensions[1]];

            for (int i = 0; i < dimensions[0]; i++)
            {
                int[] rowValues = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int j = 0; j < dimensions[1]; j++)
                {
                    matrix[i, j] = rowValues[j];
                }
            }

            Dictionary<int[], List<int[]>> origins = new Dictionary<int[], List<int[]>>();

            FindOrigins(matrix, origins, 0, 0, new List<int[]>());

            Console.WriteLine(origins.Count);
        }

        private static void FindOrigins(int[,] matrix, Dictionary<int[], List<int[]>> origins, int x, int y, List<int[]> visited)
        {
            for (int i = x; i < matrix.GetLength(0); i++)
            {
                for (int j = y; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 1 && !visited.Any(e => e.SequenceEqual(new[] { i, j })))
                    {
                        visited.Add(new[] { i, j });
                        origins.Add(new[] { i, j }, new List<int[]>());

                        SearchForFires(matrix, i, j, visited);
                    }
                }
            }
        }

        private static void SearchForFires(int[,] matrix, int x, int y, List<int[]> visited)
        {
            int maxX = matrix.GetLength(0);
            int maxY = matrix.GetLength(1);

            if (y + 1 < maxY && matrix[x, y + 1] == 1 &&
                !visited.Any(e => e.SequenceEqual(new[] { x, y + 1 }))) //east
            {
                visited.Add(new[] { x, y + 1 });
                SearchForFires(matrix, x, y + 1, visited);
            }
            if (y - 1 >= 0 && matrix[x, y - 1] == 1 &&
                !visited.Any(e => e.SequenceEqual(new[] { x, y - 1 }))) //west
            {
                visited.Add(new[] { x, y - 1 });
                SearchForFires(matrix, x, y - 1, visited);
            }
            if (x + 1 < maxX && matrix[x + 1, y] == 1 &&
                !visited.Any(e => e.SequenceEqual(new[] { x + 1, y }))) //south
            {
                visited.Add(new[] { x + 1, y });
                SearchForFires(matrix, x + 1, y, visited);
            }
            if (x - 1 >= 0 && matrix[x - 1, y] == 1 &&
                !visited.Any(e => e.SequenceEqual(new[] { x - 1, y }))) //north
            {
                visited.Add(new[] { x - 1, y });
                SearchForFires(matrix, x - 1, y, visited);
            }
            if (x - 1 >= 0 && y - 1 >= 0 && matrix[x - 1, y - 1] == 1 &&
                !visited.Any(e => e.SequenceEqual(new[] { x - 1, y - 1 }))) //northwest
            {
                visited.Add(new[] { x - 1, y - 1 });
                SearchForFires(matrix, x - 1, y - 1, visited);
            }
            if (x - 1 >= 0 && y + 1 < maxY && matrix[x - 1, y + 1] == 1 &&
                !visited.Any(e => e.SequenceEqual(new[] { x - 1, y + 1 }))) //northeast
            {
                visited.Add(new[] { x - 1, y + 1 });
                SearchForFires(matrix, x - 1, y + 1, visited);
            }
            if (x + 1 < maxX && y - 1 >= 0 && matrix[x + 1, y - 1] == 1 &&
                !visited.Any(e => e.SequenceEqual(new[] { x + 1, y - 1 }))) //southwest
            {
                visited.Add(new[] { x + 1, y - 1 });
                SearchForFires(matrix, x + 1, y - 1, visited);
            }
            if (x + 1 < maxX && y + 1 < maxY && matrix[x + 1, y + 1] == 1 &&
                !visited.Any(e => e.SequenceEqual(new[] { x + 1, y + 1 }))) //southeast
            {
                visited.Add(new[] { x + 1, y + 1 });
                SearchForFires(matrix, x + 1, y + 1, visited);
            }
        }
    }
}
