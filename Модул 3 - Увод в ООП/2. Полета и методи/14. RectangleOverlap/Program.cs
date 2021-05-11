using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _14.RectangleOverlap
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Rectangle> rectangles = new Dictionary<string, Rectangle>();

            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < int.Parse(input[0]); i++)
            {
                string[] rectangleData = Console.ReadLine().Split();

                string id = rectangleData[0];
                int width = int.Parse(rectangleData[1]);
                int height = int.Parse(rectangleData[2]);
                int xTopLeft = int.Parse(rectangleData[3]);
                int yTopLeft = int.Parse(rectangleData[4]);

                Rectangle rectangle = new Rectangle(id, width, height, xTopLeft, yTopLeft);
                rectangles.Add(id, rectangle);
            }

            for (int i = 0; i < int.Parse(input[1]); i++)
            {
                string[] ids = Console.ReadLine().Split();

                Console.WriteLine(rectangles[ids[0]].CheckOverlap(rectangles[ids[1]]));
            }
        }
    }
}
