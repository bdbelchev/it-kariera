using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] condensed = new int[inputNums.Length - 1];
            int n = inputNums.Length;

            while (n > 1)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    condensed[i] = inputNums[i] + inputNums[i + 1];
                }
                inputNums = condensed;
                n--;
            }

            Console.WriteLine(inputNums[0]);
        }
    }
}
