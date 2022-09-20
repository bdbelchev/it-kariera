using System.Data;

namespace _03._Pathfinding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] labyrinth = {
                {"*", "e", "*", "-", "-", "-", "*", "*"},
                {"*", "-", "-", "-", "*", "-", "*", "*"},
                {"*", "-", "*", "-", "-", "-", "-", "-"},
                {"*", "-", "*", "-", "*", "*", "*", "-"},
                {"*", "-", "-", "-", "-", "-", "-", "-"},
                {"*", "*", "*", "*", "*", "-", "*", "*"},
                {"*", "*", "*", "*", "*", "-", "*", "*"},
                {"*", "*", "*", "*", "*", "s", "*", "*"}
            };

            int[] start = FindStart(labyrinth);
            List<List<string>> paths = new List<List<string>>();
            FindPath(labyrinth, start[0], start[1], null, new List<string>(), paths);
            foreach (List<string> path in paths)
            {
                Console.WriteLine(string.Join(" ", path));
            }
        }

        private static void FindPath(string[,] labyrinth, int row, int col, string direction, List<string> path, List<List<string>> allPaths)
        {
            if (row >= labyrinth.GetLength(0) || col >= labyrinth.GetLength(1) || row < 0 || col < 0)
            {
                return;
            }

            if (labyrinth[row, col] == "e")
            {
                path.Add(direction);
                allPaths.Add(new List<string>(path));
                path.RemoveAt(path.Count - 1);
                return;
            }

            if (labyrinth[row, col] == "-" || labyrinth[row, col] == "s")
            {
                labyrinth[row, col] = ".";
                path.Add(direction);
                PrintMatrix(labyrinth);
                FindPath(labyrinth, row, col - 1, "Left", path, allPaths);
                FindPath(labyrinth, row, col + 1, "Right", path, allPaths);
                FindPath(labyrinth, row - 1, col, "Up", path, allPaths);
                FindPath(labyrinth, row + 1, col, "Down", path, allPaths);
                path.RemoveAt(path.Count - 1);
                labyrinth[row, col] = "-";
                PrintMatrix(labyrinth);
            }
        }

        private static int[] FindStart(string[,] labyrinth)
        {
            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    if (labyrinth[i, j] == "s")
                    {
                        return new[] { i, j };
                    }
                }
            }

            return null;
        }

        private static void PrintMatrix(string[,] labyrinth)
        {
            Console.Clear();
            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    Console.Write($"{labyrinth[i, j]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Thread.Sleep(250);
        }
    }

}