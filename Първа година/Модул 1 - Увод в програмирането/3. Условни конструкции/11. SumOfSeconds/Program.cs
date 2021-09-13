using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.SumOfSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1 = int.Parse(Console.ReadLine());
            int player2 = int.Parse(Console.ReadLine());
            int player3 = int.Parse(Console.ReadLine());

            int sum = player1 + player2 + player3;
            int min = sum / 60;
            int sec = sum % 60;

            Console.WriteLine($"{min}:{sec.ToString(format:"00")}");
        }
    }
}
