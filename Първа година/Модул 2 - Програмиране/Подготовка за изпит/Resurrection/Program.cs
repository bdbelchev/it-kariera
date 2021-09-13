using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int length = int.Parse(Console.ReadLine());
                decimal width = decimal.Parse(Console.ReadLine());
                int wingLength = int.Parse(Console.ReadLine());

                decimal years = length * length * (width + (2 * wingLength));
                Console.WriteLine(years);
            }
        }
    }
}
