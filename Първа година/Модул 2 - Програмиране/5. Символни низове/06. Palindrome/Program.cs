using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Palindrome
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

            Console.WriteLine(input.CompareTo(output.ToString()) == 0 ? "True" : "False");
        }
    }
}
