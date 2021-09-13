using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SquareRootRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < lineCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(SquareRoot.GetSqrt(number));
            }
        }
    }
}
