using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Figures
{
    abstract class Shape
    {
        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public virtual string Draw()
        {
            return "";
        }
    }
}
