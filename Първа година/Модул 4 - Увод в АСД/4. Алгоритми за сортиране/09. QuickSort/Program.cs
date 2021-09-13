using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 6, 3, 25, 47, 89, 63, 52, 74 };
            QuickSort.Sort(arr, 0, arr.Length - 1);
        }
    }
}
