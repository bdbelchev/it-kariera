using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.SelectionSort;

namespace _02.EntranceSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SelectionSort.Sort(scores);

            Console.WriteLine(string.Join(" ", scores));
        }
    }
}
