﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = Math.Max(x1, x2) - Math.Min(x1, x2);
            double y = Math.Max(y1, y2) - Math.Min(y1, y2);
            double area = x * y;
            double perimeter = (x + y) * 2;
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
