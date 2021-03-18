using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());

            long integer = (long)num;

            if (integer != num)
            {
                Console.WriteLine("Rainy");
            }
            else if (num <= sbyte.MaxValue)
            {
                Console.WriteLine("Sunny");
            }
            else if (num <= int.MaxValue)
            {
                Console.WriteLine("Cloudy");
            }
            else if (num <= long.MaxValue)
            {
                Console.WriteLine("Windy");
            }
        }
    }
}
