using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoenixGrid
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string[] input = inputString.Split('.').ToArray();

            while (inputString != "ReadMe")
            {
                string reverse = string.Join("", inputString.Reverse());

                bool isValid = true;
                bool isPalindrome = reverse == inputString;

                foreach (string phrase in input)
                {
                    if (phrase.Contains(' ') || phrase.Contains('_') || phrase.Length > 3 || phrase == "")
                    {
                        isValid = false;
                    }
                }

                Console.WriteLine(isPalindrome && isValid ? "YES" : "NO");

                inputString = Console.ReadLine();
                input = inputString.Split('.').ToArray();
            }
        }
    }
}
