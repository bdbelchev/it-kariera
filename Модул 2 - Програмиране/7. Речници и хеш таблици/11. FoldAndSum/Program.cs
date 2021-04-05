using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = input.Length / 4;

            int[] leftPart = input.Take(k).Reverse().ToArray();
            int[] rightPart = input.Skip(3 * k).Take(k).Reverse().ToArray();

            int[] upperPart = leftPart.Concat(rightPart).ToArray();
            int[] lowerPart = input.Skip(k).Take(2 * k).ToArray();

            var sum = upperPart.Select((x, index) => x + lowerPart[index]);

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
