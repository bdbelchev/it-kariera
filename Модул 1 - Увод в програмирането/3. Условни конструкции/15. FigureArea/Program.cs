using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.FigureArea
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            double area = 0;

            if (shape == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (shape == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
            }
            else if (shape == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
            }
            else if (shape == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double altitude = double.Parse(Console.ReadLine());
                area = (side * altitude) / 2;
            }

            Console.WriteLine(Math.Round(area, 3));
        }
    }
}
