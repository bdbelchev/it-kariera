using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.SpeedConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hr = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int sec = int.Parse(Console.ReadLine());

            float totalSec = sec + min * 60 + hr * 3600;

            float ms = distance / totalSec;
            float kmh = (float)distance / 1000 / (totalSec / 3600);
            float mph = (float)distance / 1609 / (totalSec / 3600);

            Console.WriteLine(Math.Round(ms, 6));
            Console.WriteLine(Math.Round(kmh, 6));
            Console.WriteLine(Math.Round(mph, 6));
        }
    }
}
