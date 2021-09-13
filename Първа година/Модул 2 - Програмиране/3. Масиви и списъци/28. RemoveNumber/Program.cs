using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.RemoveNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int badNumber = ints[ints.Count - 1];

            while (ints.Contains(badNumber))
            {
                ints.Remove(badNumber);
            }

            Console.WriteLine(string.Join(" ", ints));
        }
    }
}
