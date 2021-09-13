using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int totalDays = int.Parse(Console.ReadLine());
            int overtimeWorkers = int.Parse(Console.ReadLine());

            double workDays = 0.9 * totalDays;
            double overtime = overtimeWorkers * 2 * totalDays;
            double workHours = Math.Floor(workDays * 8 + overtime);

            Console.WriteLine(workHours >= hoursNeeded
                ? $"Yes!{workHours - hoursNeeded} hours left."
                : $"Not enough time!{hoursNeeded - workHours} hours needed.");
        }
    }
}
