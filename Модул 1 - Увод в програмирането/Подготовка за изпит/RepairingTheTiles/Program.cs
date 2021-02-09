using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairingTheTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileHeight = double.Parse(Console.ReadLine());
            int benchWidth = int.Parse(Console.ReadLine());
            int benchHeight = int.Parse(Console.ReadLine());

            int squareArea = side * side;
            int benchArea = benchHeight * benchWidth;
            int areaToBeCovered = squareArea - benchArea;
            double tileArea = tileWidth * tileHeight;
            double tilesNeeded = areaToBeCovered / tileArea;

            double timeNeeded = tilesNeeded * 0.2;

            Console.WriteLine(Math.Round(tilesNeeded, 2));
            Console.WriteLine(Math.Round(timeNeeded, 2));
        }
    }
}
