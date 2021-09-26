using System;
using System.Linq;

namespace _06._ColoredFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                switch (input[0])
                {
                    case "Circle":
                        Circle circle = new Circle(input[1], int.Parse(input[2]));
                        circle.Show();
                        break;
                    case "Square":
                        Square square = new Square(input[1], int.Parse(input[2]));
                        square.Show();
                        break;
                    case "Triangle":
                        Triangle triangle = new Triangle(input[1], int.Parse(input[2]));
                        triangle.Show();
                        break;
                }
            }
        }
    }
}
