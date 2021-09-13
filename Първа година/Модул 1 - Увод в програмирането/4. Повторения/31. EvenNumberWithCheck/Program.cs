using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.EvenNumberWithCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    int num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        Console.WriteLine($"Even number entered: {num}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The number is not even.");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid number!");
                }
            }
        }
    }
}
