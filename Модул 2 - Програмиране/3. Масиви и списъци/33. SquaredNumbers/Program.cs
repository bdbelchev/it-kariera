using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.SquaredNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> squares = new List<int>();

            foreach (int i in ints)
            {
                if (Math.Sqrt(i) == (int)Math.Sqrt(i))
                {
                    squares.Add(i);
                }
            }

            squares.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
