using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace _31.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] bomb = new int[2];
            bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (ints.Contains(bomb[0]))
            {
                int[] explode = DefineRange(ints, bomb);
                ints.RemoveRange(explode[0], explode[1]);
            }

            Console.WriteLine(ints.Sum());
        }

        private static int[] DefineRange(List<int> ints, int[] bomb)
        {
            int startRange = 0;
            int endRange = 0;

            foreach (int n in ints)
            {
                if (n == bomb[0])
                {
                    startRange = ints.IndexOf(bomb[0]) - bomb[1];
                    endRange = ints.IndexOf(bomb[0]) + bomb[1];

                    if (startRange < 0)
                    {
                        startRange = 0;
                    }

                    if (endRange > ints.Count)
                    {
                        endRange = ints.Count - 1;
                    }

                    break;
                }
            }
            int removeLength = endRange - startRange + 1;

            return new[] { startRange, removeLength };
        }
    }
}