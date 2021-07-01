using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int search = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearch(ints, search, 0, ints.Length));
        }

        static int BinarySearch(int[] arr, int el, int start, int end)
        {
            int mid = (start + end) / 2;

            if (arr[mid] > el)
            {
                return BinarySearch(arr, el, start, mid - 1);
            }

            if (arr[mid] < el)
            {
                return BinarySearch(arr, el, mid + 1, end);
            }

            return mid;
        }
    }
}
