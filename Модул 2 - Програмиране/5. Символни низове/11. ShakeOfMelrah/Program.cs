using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ShakeOfMelrah
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (inputString.Contains(pattern))
            {
                int firstIndex = inputString.IndexOf(pattern);
                int lastIndex = inputString.LastIndexOf(pattern);

                if (firstIndex != lastIndex)
                {
                    inputString = inputString.Remove(lastIndex, pattern.Length);
                    inputString = inputString.Remove(firstIndex, pattern.Length);
                    Console.WriteLine("Shaked it.");
                }
                else
                {
                    inputString = inputString.Remove(lastIndex, pattern.Length);
                    break;
                }

                pattern = pattern.Remove(pattern.Length / 2, 1);
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(inputString);
        }
    }
}
