using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int smallest = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    smallest = currentNumber;
                }
                else if (currentNumber < smallest)
                {
                    smallest = currentNumber;
                }
            }

            Console.WriteLine(smallest);
        }
    }
}
