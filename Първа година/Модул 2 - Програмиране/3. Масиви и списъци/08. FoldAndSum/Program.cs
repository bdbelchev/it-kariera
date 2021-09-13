using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = array.Length / 4;

            int[] firstPart = new int[k];
            int[] center = new int[2 * k];
            int[] lastPart = new int[k];

            for (int i = 0; i < firstPart.Length; i++)
            {
                firstPart[i] = array[i];
            }

            for (int i = 0; i < center.Length; i++)
            {
                center[i] = array[i + k];
            }

            for (int i = 0; i < lastPart.Length; i++)
            {
                lastPart[i] = array[i + 3 * k];
            }

            firstPart = firstPart.Reverse().ToArray();
            lastPart = lastPart.Reverse().ToArray();

            int[] onTop = firstPart.Concat(lastPart).ToArray();

            int[] sum = new int[onTop.Length];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] += onTop[i] + center[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
