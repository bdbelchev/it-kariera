using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.EvenNumberList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            foreach (int i in ints)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
