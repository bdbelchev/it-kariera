using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int pipe1Debit = int.Parse(Console.ReadLine());
            int pipe2Debit = int.Parse(Console.ReadLine());
            double timeAway = double.Parse(Console.ReadLine());

            double pipe1Amount = timeAway * pipe1Debit;
            double pipe2Amount = timeAway * pipe2Debit;
            double totalAmount = pipe2Amount + pipe1Amount;

            if (totalAmount > poolVolume)
            {
                Console.WriteLine($"For {timeAway} hours the pool overflows with {Math.Round(totalAmount - poolVolume, 1)} liters.");
            }
            else
            {
                double totalPercentage = Math.Floor((100 * totalAmount) / (poolVolume));
                double pipe1Percentage = Math.Floor((100 * pipe1Amount) / (totalAmount));
                double pipe2Percentage = Math.Floor((100 * pipe2Amount) / (totalAmount));

                Console.WriteLine($"The pool is {totalPercentage}% full. Pipe 1: {pipe1Percentage}%. Pipe 2: {pipe2Percentage}%.");
            }
        }
    }
}
