using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = FahrenheitToCelsius(fahrenheit);

            Console.WriteLine($"{celsius:f2}");
        }

        private static double FahrenheitToCelsius(double f)
        {
            return (f - 32) * 5 / 9;
        }
    }
}
