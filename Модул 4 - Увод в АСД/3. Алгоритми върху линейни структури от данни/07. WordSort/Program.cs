using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.WordSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = Console.ReadLine().Split().ToList();

            strings.Sort();

            Console.WriteLine(string.Join(" ", strings));
        }
    }
}
