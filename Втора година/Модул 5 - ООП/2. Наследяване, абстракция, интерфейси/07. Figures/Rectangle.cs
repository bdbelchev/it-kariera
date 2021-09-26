using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Figures
{
    class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Draw()
        {
            Console.WriteLine(new string('*', width));

            for (int i = 0; i < height - 2; i++)
            {
                Console.WriteLine($"*{new string(' ', width - 2)}*");
            }

            Console.WriteLine(new string('*', width));
        }
    }
}
