using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());
            int holidayPlayMinutes = 127;
            int workDayPlayMinutes = 63;
            int maxPlayTime = 30000;

            int holidayPlayTime = holidayPlayMinutes * holidays;
            int workDayPlayTime = (365 - holidays) * workDayPlayMinutes;
            int totalPlayTime = holidayPlayTime + workDayPlayTime;

            int difference = Math.Abs(totalPlayTime - maxPlayTime);
            int differenceInHours = difference / 60;
            int differenceInMinutes = difference % 60;

            if (totalPlayTime > maxPlayTime)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{differenceInHours} hours and {differenceInMinutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{differenceInHours} hours and {differenceInMinutes} minutes less for play");
            }
        }
    }
}
