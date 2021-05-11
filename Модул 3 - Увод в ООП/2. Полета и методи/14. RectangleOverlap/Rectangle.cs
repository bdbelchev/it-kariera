using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace _14.RectangleOverlap
{
    class Rectangle
    {
        private string id;
        private int width;
        private int height;
        private int xTopLeft;
        private int yTopLeft;

        public Rectangle(string id, int width, int height, int xTopLeft, int yTopLeft)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.xTopLeft = xTopLeft;
            this.yTopLeft = yTopLeft;
        }

        public bool CheckOverlap(Rectangle rectangle)
        {
            return rectangle.xTopLeft + rectangle.width >= this.xTopLeft &&
                   rectangle.xTopLeft <= this.xTopLeft + this.width &&
                   rectangle.yTopLeft >= this.yTopLeft - this.height &&
                   rectangle.yTopLeft - rectangle.height <= this.yTopLeft;
        }
    }
}
