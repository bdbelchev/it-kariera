using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = n - 1;

            while (num >= 1)
            {
                n *= num;
                num--;
            }

            Console.WriteLine(n);
        }
    }
}
