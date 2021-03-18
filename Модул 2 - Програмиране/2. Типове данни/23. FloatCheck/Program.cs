using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.FloatCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());

            long integer = (long)input;

            Console.WriteLine(input == integer ? "integer" : "floating-point");
        }
    }
}
