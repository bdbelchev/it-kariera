using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
            char[] digits = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            char input = char.Parse(Console.ReadLine().ToLower());

            if (vowels.Contains(input))
            {
                Console.WriteLine("vowel");
            }
            else if (digits.Contains(input))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
