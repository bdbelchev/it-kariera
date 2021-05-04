using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpringClothes
{
    class Program
    {
        static void Main(string[] args)
        {
            int items = int.Parse(Console.ReadLine());
            double total = 0;

            for (int i = 0; i < items; i++)
            {
                switch (Console.ReadLine())
                {
                    case "jeans":
                        total += 50;
                        break;
                    case "t-shirt":
                        total += 20;
                        break;
                    case "trainers":
                        total += 70;
                        break;
                    case "jacket":
                        total += 60;
                        break;
                }
            }

            Console.WriteLine($"{total:f2}");
        }
    }
}
