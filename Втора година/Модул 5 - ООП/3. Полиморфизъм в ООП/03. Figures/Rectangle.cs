using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Figures
{
    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculatePerimeter()
        {
            return (width + height) * 2;
        }

        public override double CalculateArea()
        {
            return width * height;
        }

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(new string('*', (int)width));

            for (int i = 0; i < height - 2; i++)
            {
                sb.AppendLine($"*{new string(' ', (int)(width - 2))}*");
            }

            sb.AppendLine(new string('*', (int)width));

            return sb.ToString();
        }
    }
}
