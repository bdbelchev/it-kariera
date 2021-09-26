using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._ColoredFigure
{
    class Square : ColoredFigure
    {
        public Square(string color, int size) : base(color, size) { }

        public override string GetName()
        {
            return "Square";
        }

        public override double GetArea()
        {
            return Math.Pow(size, 2);
        }

        public override void Show()
        {
            Console.WriteLine($"{GetName()}:");
            base.Show();
            Console.WriteLine($"Area: {GetArea():f2}");
        }
    }
}
