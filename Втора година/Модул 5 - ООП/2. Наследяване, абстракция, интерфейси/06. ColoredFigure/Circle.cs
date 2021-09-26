using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._ColoredFigure
{
    class Circle : ColoredFigure
    {
        public Circle(string color, int size) : base(color, size) { }

        public override string GetName()
        {
            return "Circle";
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(size, 2);
        }

        public override void Show()
        {
            Console.WriteLine($"{GetName()}:");
            base.Show();
            Console.WriteLine($"Area: {GetArea():f2}");
        }
    }
}
