using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ShortWordSort
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] splitterChars = new[] { '.', ',', ' ', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?' };

            string[] words = Console.ReadLine().ToLower().Split(splitterChars, StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<string> result = words.Where(word => word.Length < 5).ToList();
            result = result.Distinct().OrderBy(word => word).ToList();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
