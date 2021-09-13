using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38.NumberSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int elementsNeeded = input[0];
            int elementsToDel = input[1];
            int numberToSearch = input[2];

            ints.RemoveRange(elementsNeeded, ints.Count - elementsNeeded);

            ints.RemoveRange(0, elementsToDel);

            Console.WriteLine(ints.Contains(numberToSearch) ? "YES!" : "NO!");
        }
    }
}
