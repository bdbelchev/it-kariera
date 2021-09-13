using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.NumberCount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            ints.Sort();

            for (int i = 0; i < ints.Count; i++)
            {
                int counter = 0;

                foreach (int j in ints)
                {
                    if (ints[i] == j)
                    {
                        counter++;
                    }
                }

                if (i == ints.Count - 1 || (i < ints.Count && ints[i] != ints[i + 1]))
                {
                    Console.WriteLine($"{ints[i]} -> {counter}");
                }
            }
        }
    }
}
