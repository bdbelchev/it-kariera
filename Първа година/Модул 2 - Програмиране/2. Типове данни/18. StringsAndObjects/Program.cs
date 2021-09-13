using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";

            object combined = hello + " " + world;

            string combinedString = combined.ToString();
            Console.WriteLine(combinedString);
        }
    }
}
