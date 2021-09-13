using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(ints);
            Console.WriteLine(string.Join(" ", ints));
        }
    }
}
