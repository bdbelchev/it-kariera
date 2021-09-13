using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.Beers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string biggestKeg = "";
            double biggestVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                double kegVolume = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;

                if (kegVolume > biggestVolume)
                {
                    biggestVolume = kegVolume;
                    biggestKeg = kegModel;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
