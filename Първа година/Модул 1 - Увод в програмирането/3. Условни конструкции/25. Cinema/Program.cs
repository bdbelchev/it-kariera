using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double price = 0;
            double result = 0;

            switch (projection)
            {
                case "Premiere":
                    price = 12;
                    break;
                case "Normal":
                    price = 7.5;
                    break;
                case "Discount":
                    price = 5;
                    break;
            }

            result = r * c * price;
            Console.Write("{0:f2}", result);
            Console.WriteLine(" leva");
        }
    }
}
