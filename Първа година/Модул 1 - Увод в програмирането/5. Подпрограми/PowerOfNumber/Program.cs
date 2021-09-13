using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfNumber
{
    class Program
    {
        static double CalculatePower(double number, double power)
        {
            return Math.Pow(number, power);
        }

        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine(CalculatePower(n, p));
        }
    }
}
