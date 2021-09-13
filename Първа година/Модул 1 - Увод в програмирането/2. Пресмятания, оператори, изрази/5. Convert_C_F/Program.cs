using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Convert_C_F
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature in °C: ");
            double c = double.Parse(Console.ReadLine());
            double f = c * 1.8 + 32;
            Console.WriteLine(f);
        }
    }
}
