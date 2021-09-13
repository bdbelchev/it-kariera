using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.ListOfNames2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesList = Console.ReadLine().Split(',').ToList();

            foreach (string name in namesList)
            {
                List<string> splitNames = name.Split(' ').ToList();
                splitNames.Reverse();
                Console.WriteLine(string.Join(" ", splitNames));
            }
        }
    }
}
 