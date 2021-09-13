using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _39.CompareFloatingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = Math.Abs(double.Parse(Console.ReadLine()));
            double number2 = Math.Abs(double.Parse(Console.ReadLine()));

            double eps = 0.000001;

            Console.WriteLine(Math.Abs(number1 - number2) < eps ? "True" : "False");
        }
    }
}
