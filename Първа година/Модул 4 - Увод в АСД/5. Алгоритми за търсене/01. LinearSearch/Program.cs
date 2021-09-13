using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int search = int.Parse(Console.ReadLine());

            Console.WriteLine(LinearSearch(ints, search));
        }

        static int LinearSearch<T>(T[] arr, T el)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (Equals(arr[i], el))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
