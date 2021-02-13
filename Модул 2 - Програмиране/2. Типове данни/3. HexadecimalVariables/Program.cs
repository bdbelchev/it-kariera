using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.HexadecimalVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexNumber = Console.ReadLine();
            int hexOutput = Convert.ToInt32(hexNumber, 16);
            Console.WriteLine(hexOutput);
        }
    }
}
