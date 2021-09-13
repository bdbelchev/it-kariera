using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.WordCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string word = "";

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                word += letter;
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}
