using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            DateModifier dateModifier = new DateModifier();

            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            Console.WriteLine((dateModifier.DateDifference(date1, date2)));
        }
    }
}
