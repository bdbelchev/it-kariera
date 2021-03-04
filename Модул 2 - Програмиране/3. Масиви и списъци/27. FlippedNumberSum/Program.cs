using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.FlippedNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;

            foreach (int i in ints)
            {
                sum += int.Parse(string.Join("", i.ToString().Reverse()));
            }

            Console.WriteLine(sum);
        }
    }
}
