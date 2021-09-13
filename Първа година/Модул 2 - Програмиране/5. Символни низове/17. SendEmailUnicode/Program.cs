using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.SendEmailUnicode
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
                leftSum += Convert.ToInt32(Convert.ToString(c, 16), 16);
            }

            foreach (char c in mail[1])
            {
                rightSum += Convert.ToInt32(Convert.ToString(c, 16), 16);
            }

            Console.WriteLine(leftSum - rightSum >= 0 ? "Call her!" : "She is not the one");
        }
    }
}
