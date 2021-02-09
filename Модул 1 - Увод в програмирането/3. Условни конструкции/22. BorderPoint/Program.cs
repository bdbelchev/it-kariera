using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.BorderPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (x1 > x2)
            {
                double bigger = x1;
                x1 = x2;
                x2 = bigger;
            }
            if (y1 > y2)
            {
                double bigger = y1;
                y1 = y2;
                y2 = bigger;
            }

            if (((x == x1 || x == x2) && y >= y1 && y <= y2) || ((y == y1 || y == y2) && x >= x1 && x <= x2))
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
