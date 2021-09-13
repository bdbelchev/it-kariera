using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] valueSplitters = new[] { '{', '}' };

            string encoded = Console.ReadLine();
            string[] values = Console.ReadLine().Split(valueSplitters, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Regex placeholderDetect = new Regex(@"([A-Za-z]+).+\1");
            var placeholders = placeholderDetect.Matches(encoded);

            int i = 0;

            foreach (Match placeholder in placeholders)
            {
                if (i < values.Length)
                {
                    encoded = encoded.Replace(placeholder.Value, $"{placeholder.Groups[1]}{values[i++]}{placeholder.Groups[1]}");
                }
            }

            Console.WriteLine(encoded);
        }
    }
}
