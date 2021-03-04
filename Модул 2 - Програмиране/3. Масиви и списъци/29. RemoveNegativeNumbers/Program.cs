using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.RemoveNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> positiveInts = new List<int>();

            foreach (int i in ints)
            {
                if (i > 0)
                {
                    positiveInts.Add(i);
                }
            }

            positiveInts.Reverse();

            Console.WriteLine(positiveInts.Count == 0 ? "Empty" : string.Join(" ", positiveInts));
        }
    }
}
