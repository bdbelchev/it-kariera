using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.MergeSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] newArr = new int[arr1.Length + arr2.Length];

            Array.Copy(arr1, newArr, arr1.Length);
            Array.Copy(arr2, 0, newArr, arr1.Length, arr2.Length);

            Array.Sort(newArr);

            Console.WriteLine(string.Join(" ", newArr));
        }
    }
}
