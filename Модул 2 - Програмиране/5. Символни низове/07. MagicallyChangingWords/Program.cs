using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MagicallyChangingWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = Console.ReadLine().Split(' ').ToArray();

            char[] str1Chars = inputStrings[0].ToCharArray();
            char[] str2Chars = inputStrings[1].ToCharArray();

            bool isReplaceable = CheckStrings(str1Chars, str2Chars);

            Console.WriteLine(isReplaceable);
        }

        private static bool CheckStrings(char[] str1, char[] str2)
        {
            str1 = str1.Distinct().ToArray();
            str2 = str2.Distinct().ToArray();

            return str1.Length == str2.Length;
        }
    }
}
