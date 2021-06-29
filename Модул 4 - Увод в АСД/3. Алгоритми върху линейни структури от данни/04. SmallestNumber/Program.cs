using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SmallestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int minimum = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                if (minimum > input[i])
                {
                    minimum = input[i];
                }
            }

            Console.WriteLine(minimum);
        }
    }
}
