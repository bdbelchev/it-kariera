using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _06.Box_Validation
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get { return length; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public double Volume()
        {
            return this.length * this.width * this.height;
        }

        public double LateralSurfaceArea()
        {
            return 2 * length * height + 2 * width * height;
        }

        public double SurfaceArea()
        {
            return 2 * length * width + 2 * length * height + 2 * width * height;
        }
    }
}