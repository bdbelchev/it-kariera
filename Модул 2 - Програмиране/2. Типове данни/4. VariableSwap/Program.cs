using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.VariableSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;
            byte b = 10;
            Console.WriteLine($"Before:\na = {a}\nb = {b}");

            byte temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After:\na = {a}\nb = {b}");
        }
    }
}
