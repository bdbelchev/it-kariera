using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.SelectionSort;

namespace _04.CrossRunning
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstDay = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondDay = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] total = new int[firstDay.Length + secondDay.Length];
            firstDay.CopyTo(total, 0);
            secondDay.CopyTo(total, firstDay.Length);

            SelectionSort.Sort(total);

            Console.WriteLine(string.Join(" ", total));
        }
    }
}
