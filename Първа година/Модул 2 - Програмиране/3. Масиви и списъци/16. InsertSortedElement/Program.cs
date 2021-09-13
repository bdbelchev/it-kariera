using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.InsertSortedElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            int[] newInts = new int[ints.Length+1];
            ints.CopyTo(newInts, 0);
            newInts[newInts.Length - 1] = n;
            Array.Sort(newInts);

            Console.WriteLine(string.Join(" ", newInts));
        }
    }
}
