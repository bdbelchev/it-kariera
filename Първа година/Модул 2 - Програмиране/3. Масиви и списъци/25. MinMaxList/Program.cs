using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.MinMaxList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> minMaxInts = new List<int>();

            foreach (int i in ints)
            {
                if (i == ints.Max() || i == ints.Min())
                {
                    minMaxInts.Add(i);
                }
            }

            minMaxInts.Sort();
            Console.WriteLine(string.Join(" ", minMaxInts));
        }
    }
}
