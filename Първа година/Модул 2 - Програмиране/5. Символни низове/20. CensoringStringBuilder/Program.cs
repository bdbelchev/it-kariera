using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.CensoringStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string bannedWord = Console.ReadLine();
            StringBuilder input = new StringBuilder(Console.ReadLine());

            input.Replace(bannedWord, new string('*', bannedWord.Length));
            Console.WriteLine(input);
        }
    }
}
