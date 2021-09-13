using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.TouristInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperial = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            double result = 0;
            string metric = "";

            switch (imperial)
            {
                case "miles":
                    result = value * 1.6;
                    metric = "kilometers";
                    break;
                case "inches":
                    result = value * 2.54;
                    metric = "centimeters";
                    break;
                case "feet":
                    result = value * 30;
                    metric = "centimeters";
                    break;
                case "yards":
                    result = value * 0.91;
                    metric = "meters";
                    break;
                case "gallons":
                    result = value * 3.8;
                    metric = "liters";
                    break;
            }

            Console.WriteLine($"{value} {imperial} = {result:f2} {metric}");
        }
    }
}
