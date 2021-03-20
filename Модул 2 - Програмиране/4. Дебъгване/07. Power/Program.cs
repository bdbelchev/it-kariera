using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = RaiseToPower(number, power);

            Console.WriteLine(result);
        }

        private static double RaiseToPower(double n, int p)
        {
            double result = n;

            for (int i = 2; i <= p; i++)
            {
                result *= n;
            }

            return result;
        }
    }
}
