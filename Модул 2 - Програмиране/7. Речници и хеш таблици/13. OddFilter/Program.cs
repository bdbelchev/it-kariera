using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).Where(x => x % 2 == 0).ToArray();

            int[] smaller = input.Where(x => x <= input.Average()).Select(x => x - 1).ToArray();
            int[] bigger = input.Where(x => x > input.Average()).Select(x => x + 1).ToArray();

            int[] result = smaller.Concat(bigger).ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
