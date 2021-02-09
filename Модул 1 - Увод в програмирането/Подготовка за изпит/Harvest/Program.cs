using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int yardArea = int.Parse(Console.ReadLine());
            double grapesPerSquareMeter = double.Parse(Console.ReadLine());
            int litersOfWineNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double totalGrapes = yardArea * grapesPerSquareMeter;
            double totalWine = 0.4 * totalGrapes / 2.5;

            if (totalWine < litersOfWineNeeded)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(litersOfWineNeeded - totalWine)} liters wine needed.");
            }
            else
            {
                double litersPerWorker = (totalWine - litersOfWineNeeded) / workers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(totalWine - litersOfWineNeeded)} liters left -> {Math.Ceiling(litersPerWorker)} liters per person.");
            }
        }
    }
}
