using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberryPrice = double.Parse(Console.ReadLine());
            double bananaAmount = double.Parse(Console.ReadLine());
            double orangeAmount = double.Parse(Console.ReadLine());
            double raspberryAmount = double.Parse(Console.ReadLine());
            double strawberryAmount = double.Parse(Console.ReadLine());

            double raspberryPrice = strawberryPrice / 2;
            double orangePrice = 0.6 * raspberryPrice;
            double bananaPrice = 0.2 * raspberryPrice;

            double strawberrySum = strawberryAmount * strawberryPrice;
            double orangeSum = orangeAmount * orangePrice;
            double raspberrySum = raspberryAmount * raspberryPrice;
            double bananaSum = bananaAmount * bananaPrice;

            double total = strawberrySum + orangeSum + raspberrySum + bananaSum;

            Console.WriteLine($"{total:f2}");
        }
    }
}
