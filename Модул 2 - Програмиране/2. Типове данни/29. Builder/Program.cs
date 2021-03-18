using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            long total = 0;

            if (num1 <= sbyte.MaxValue)
            {
                total += 4 * num1 + (long)10 * num2;
            }
            else
            {
                total += 4 * num2 + (long)10 * num1;
            }

            Console.WriteLine(total);
        }
    }
}
