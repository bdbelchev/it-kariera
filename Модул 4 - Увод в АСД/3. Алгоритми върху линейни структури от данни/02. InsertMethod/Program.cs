using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.InsertMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(input);

            int insert = int.Parse(Console.ReadLine());

            List<int> newInts = new List<int>();
            newInts.AddRange(input);

            for (int i = 0; i < newInts.Count; i++)
            {
                if (insert < newInts[i])
                {
                    newInts.Insert(i, insert);
                    break;
                }
            }

            Console.WriteLine($"Before: {string.Join(" ", input)}");
            Console.WriteLine($"After: {string.Join(" ", newInts)}");
        }
    }
}
