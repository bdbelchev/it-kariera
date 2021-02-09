using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());

            int examInMinutes = examHour * 60 + examMinute;
            int arrivalInMinutes = arrivalHour * 60 + arrivalMinute;

            int differenceInMinutes = arrivalInMinutes - examInMinutes;
            int h = Math.Abs(differenceInMinutes) / 60;
            int m = Math.Abs(differenceInMinutes) % 60;

            if (differenceInMinutes < -30)
            {
                Console.WriteLine("Early");
                Console.WriteLine(Math.Abs(differenceInMinutes) >= 60
                    ? $"{h}:{m:00} hours before the start"
                    : $"{Math.Abs(differenceInMinutes)} minutes before the start");
            }
            else if (differenceInMinutes > 0)
            {
                Console.WriteLine("Late");
                Console.WriteLine(Math.Abs(differenceInMinutes) >= 60
                    ? $"{h}:{m:00} hours after the start"
                    : $"{Math.Abs(differenceInMinutes)} minutes after the start");
            }
            else
            {
                Console.WriteLine("On time");
                if (differenceInMinutes != 0)
                {
                    Console.WriteLine(Math.Abs(differenceInMinutes) >= 60
                        ? $"{h}:{m:00} hours before the start"
                        : $"{Math.Abs(differenceInMinutes)} minutes before the start");
                }
            }
        }
    }
}