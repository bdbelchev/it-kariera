using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double price = 0;

            if (n >= 100)
            {
                price = n * 0.06;
            }
            else if (n >= 20)
            {
                price = n * 0.09;
            }
            else
            {
                if (time == "day")
                {
                    price = 0.7 + n * 0.79;
                }
                else if (time == "night")
                {
                    price = 0.7 + n * 0.9;
                }
            }

            Console.WriteLine(Math.Round(price, 2));
        }
    }
}
