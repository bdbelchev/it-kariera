using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Figures
{
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();

            double r_in = radius - 0.4;
            double r_out = radius + 0.4;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < r_out; x += 0.5)
                {
                    double value = x * x + y * y;

                    if (value >= r_in * r_in && value <= r_out * r_out)
                    {
                        sb.Append("*");
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }

                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}