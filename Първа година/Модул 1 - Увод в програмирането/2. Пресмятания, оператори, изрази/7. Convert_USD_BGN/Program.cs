using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Convert_USD_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value in USD: ");
            double usd = double.Parse(Console.ReadLine());
            double bgn = usd * 1.79549;
            Console.WriteLine(Math.Round(bgn, 2));
        }
    }
}
