using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38.RefactorPrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //ОРИГИНАЛ:
            //int ___Do___ = int.Parse(Console.ReadLine());
            //for (int DAVIDIM = 0; DAVIDIM <= ___Do___; DAVIDIM++)
            //{    bool TowaLIE = true;
            //    for (int delio = 2; delio <= Math.Sqrt(DAVIDIM); delio++)
            //    {
            //        if  (DAVIDIM % delio == 0)
            //        {
            //            TowaLIE = false;
            //            break;
            //        }
            //    }
            //    Console.WriteLine($"{DAVIDIM} -> {TowaLIE}");
            //}

            int input = int.Parse(Console.ReadLine());

            for (int i = 2; i <= input; i++)
            {
                bool isPrime = true;

                for (int n = 2; n <= Math.Sqrt(i); n++)
                {
                    if (i % n == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{i} -> {isPrime}");
            }
        }
    }
}
