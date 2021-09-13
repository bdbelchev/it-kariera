using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new[] { 4, 5, 2, 7, 8, 4, 7, 3, 2, 78, 45, 65, 98, 412, 974, 50 };
            
            InsertionSort.Sort(a);

            Console.WriteLine(string.Join(", ", a));
        }
    }
}
