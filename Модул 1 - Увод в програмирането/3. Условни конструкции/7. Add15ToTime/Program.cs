using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _7.Add15ToTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            if (min + 15 >= 60)
            {
                h += 1;
                min = (min + 15) - 60;
            }
            else
            {
                min += 15;
            }

            if (h >= 24)
            {
                h -= 24;
            }

            Console.WriteLine($"{h}:{min.ToString("00")}");
        }
    }
}
