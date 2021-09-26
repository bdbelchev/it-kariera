using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._ColoredFigure
{
    abstract class ColoredFigure
    {
        private string color;
        protected int size;

        protected ColoredFigure(string color, int size)
        {
            this.color = color;
            this.size = size;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Size: {size}");
        }

        public abstract string GetName();
        public abstract double GetArea();
    }
}
