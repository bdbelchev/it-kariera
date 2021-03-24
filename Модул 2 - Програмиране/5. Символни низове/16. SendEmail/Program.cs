using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.SendEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mail = Console.ReadLine().Split('@');

            int leftSum = 0;
            int rightSum = 0;

            foreach (char c in mail[0])
            {
                leftSum += c;
            }

            foreach (char c in mail[1])
            {
                rightSum += c;
            }

            Console.WriteLine(leftSum - rightSum >= 0 ? "Call her!" : "She is not the one");
        }
    }
}
