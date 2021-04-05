using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.HourSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] input = Console.ReadLine().Split(' ').Select(DateTime.Parse).ToArray();

            input = input.OrderBy(time => time).ToArray();

            Console.WriteLine(string.Join(", ", input.Select(x => x.ToString("HH:mm"))));
        }
    }
}
