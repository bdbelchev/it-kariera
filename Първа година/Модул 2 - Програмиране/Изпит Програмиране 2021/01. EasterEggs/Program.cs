using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggCount = int.Parse(Console.ReadLine());

            int redEggs = 0;
            int orangeEggs = 0;
            int blueEggs = 0;
            int greenEggs = 0;
            int maxEggs = 0;

            for (int i = 0; i < eggCount; i++)
            {
                switch (Console.ReadLine())
                {
                    case "red":
                        redEggs++;
                        break;
                    case "orange":
                        orangeEggs++;
                        break;
                    case "blue":
                        blueEggs++;
                        break;
                    case "green":
                        greenEggs++;
                        break;
                }
            }

            string maxColor = "";

            if (blueEggs >= maxEggs)
            {
                maxEggs = blueEggs;
                maxColor = "blue";
            }

            if (greenEggs >= maxEggs)
            {
                maxEggs = greenEggs;
                maxColor = "green";
            }

            if (orangeEggs >= maxEggs)
            {
                maxEggs = orangeEggs;
                maxColor = "orange";
            }

            if (redEggs >= maxEggs)
            {
                maxEggs = redEggs;
                maxColor = "red";
            }

            Console.WriteLine($"Red eggs: {redEggs}");
            Console.WriteLine($"Orange eggs: {orangeEggs}");
            Console.WriteLine($"Blue eggs: {blueEggs}");
            Console.WriteLine($"Green eggs: {greenEggs}");
            Console.WriteLine($"Max eggs: {maxEggs} -> {maxColor}");
        }
    }
}
