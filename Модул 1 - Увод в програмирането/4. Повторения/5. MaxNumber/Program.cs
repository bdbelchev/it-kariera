using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int biggest = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    biggest = currentNumber;
                }
                else if (currentNumber > biggest)
                {
                    biggest = currentNumber;
                }
            }

            Console.WriteLine(biggest);
        }
    }
}
