using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.UnitConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();

            double mm = 1000;
            double cm = 100;
            double mi = 0.000621371192;
            double inch = 39.3700787;
            double km = 0.001;
            double ft = 3.2808399;
            double yd = 1.0936133;

            double resultInMeters = 0;
            double result = 0;

            switch (from)
            {
                case "mm":
                    resultInMeters = distance / mm;
                    break;
                case "cm":
                    resultInMeters = distance / cm;
                    break;
                case "mi":
                    resultInMeters = distance / mi;
                    break;
                case "in":
                    resultInMeters = distance / inch;
                    break;
                case "km":
                    resultInMeters = distance / km;
                    break;
                case "ft":
                    resultInMeters = distance / ft;
                    break;
                case "yd":
                    resultInMeters = distance / yd;
                    break;
                case "m":
                    resultInMeters = distance;
                    break;
            }

            switch (to)
            {
                case "mm":
                    result = resultInMeters * mm;
                    break;
                case "cm":
                    result = resultInMeters * cm;
                    break;
                case "mi":
                    result = resultInMeters * mi;
                    break;
                case "in":
                    result = resultInMeters * inch;
                    break;
                case "km":
                    result = resultInMeters * km;
                    break;
                case "ft":
                    result = resultInMeters * ft;
                    break;
                case "yd":
                    result = resultInMeters * yd;
                    break;
                case "m":
                    result = resultInMeters;
                    break;
            }

            Console.WriteLine($"{result} {to}");
        }
    }
}
