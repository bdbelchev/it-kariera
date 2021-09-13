using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder output = new StringBuilder(input.Length);

            for (int i = input.Length - 1; i >= 0; i--)
            {
                output.Append(input[i]);
            }

            Console.WriteLine(output);
        }
    }
}
