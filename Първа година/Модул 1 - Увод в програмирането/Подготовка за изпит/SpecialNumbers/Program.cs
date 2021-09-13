using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int first = int.Parse(i.ToString().Substring(0, 1));
                int second = int.Parse(i.ToString().Substring(1, 1));
                int third = int.Parse(i.ToString().Substring(2, 1));
                int fourth = int.Parse(i.ToString().Substring(3, 1));

                if (first == 0 || second == 0 || third == 0 || fourth == 0)
                {
                    continue;
                }
                if (n % first == 0 && n % second == 0 && n % third == 0 && n % fourth == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
