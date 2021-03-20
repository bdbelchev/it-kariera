using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.EmptyCashReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        private static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        private static void PrintFooter()
        {
            Console.WriteLine("------------------------------\n\u00A9 BG");
        }

        private static void PrintBody()
        {
            Console.WriteLine("Charged to____________________\nReceived by___________________");
        }

        private static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT\n------------------------------");
        }
    }
}
