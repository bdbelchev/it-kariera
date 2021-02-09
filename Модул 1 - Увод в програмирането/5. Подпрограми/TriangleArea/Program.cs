using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static double GetTriangleArea(double length, double height)
        {
            return (length * height) / 2;
        }

        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(a, h);
            Console.WriteLine(area);
        }
    }
}
