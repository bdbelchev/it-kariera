using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double heightInMeters = double.Parse(Console.ReadLine());
            double widthInMeters = double.Parse(Console.ReadLine());

            double heightInCm = heightInMeters * 100;
            double widthInCm = widthInMeters * 100;

            double rows = Math.Floor(heightInCm / 120);
            double desksOnEachRow = Math.Floor((widthInCm - 100) / 70);

            double totalDesks = (rows * desksOnEachRow) - 3;
            Console.WriteLine(totalDesks);
        }
    }
}
