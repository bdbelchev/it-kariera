using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string tower = "/" + new string('^', n / 2) + "\\";
            int underscoreCount = n * 2 - tower.Length * 2;
            string top = tower + new string('_', underscoreCount) + tower;

            string body = "|" + new string(' ', n * 2 - 2) + "|";
            string lastBody = "|" + new string(' ', (n * 2 - underscoreCount - 2) / 2) +
                              new string('_', underscoreCount) + new string(' ', (n * 2 - underscoreCount - 2) / 2) +
                              "|";

            string bottomTower = "\\" + new string('_', n / 2) + "/";
            string bottom = bottomTower + new string(' ', underscoreCount) + bottomTower;

            Console.WriteLine(top);
            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine(body);
            }

            Console.WriteLine(lastBody);
            Console.WriteLine(bottom);
        }
    }
}
