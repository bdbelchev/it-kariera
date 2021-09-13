using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using _01.SelectionSort;

namespace _03.PEStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] heights = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] select = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SelectionSort.Sort(heights);

            Console.WriteLine($"{heights[select[0]-1]} {heights[select[1]-1]}");
        }
    }
}
