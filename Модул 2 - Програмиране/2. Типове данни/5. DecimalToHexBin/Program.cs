using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.DecimalToHexBin
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string hex = Convert.ToString(input, 16);
            string bin = Convert.ToString(input, 2);
            Console.WriteLine($"0x{hex.ToUpper()}\n{bin}");
        }
    }
}
