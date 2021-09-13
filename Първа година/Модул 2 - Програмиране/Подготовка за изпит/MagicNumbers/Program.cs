using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputInts = Console.ReadLine().Split(',').Select(int.Parse).ToList();
            List<int> group1 = inputInts.Where(x => x % 2 == 0 && (x % 10 == 4 || x % 10 == 8)).ToList();
            List<int> group2 = inputInts.Where(x => x % 2 != 0 && (x % 10 == 5 || x % 10 == 7)).ToList();
            List<int> group3 = new List<int>();

            foreach (int i in inputInts)
            {
                int number = i;
                int sum = 0;

                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }

                if (sum == 15)
                {
                    group3.Add(i);
                }
            }

            Console.WriteLine(string.Join(", ", group1));
            Console.WriteLine(string.Join(", ", group2));
            Console.WriteLine(string.Join(", ", group3));
        }
    }
}
