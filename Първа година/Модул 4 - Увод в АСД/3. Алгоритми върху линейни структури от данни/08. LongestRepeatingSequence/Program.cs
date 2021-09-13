using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LongestRepeatingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split().Select(int.Parse).ToList();

            Dictionary<int, int> timesRepeated = new Dictionary<int, int>();

            if (sequence.Count > 1)
            {
                for (int i = 0; i < sequence.Count - 1; i++)
                {
                    if (!timesRepeated.ContainsKey(sequence[i]))
                    {
                        timesRepeated.Add(sequence[i], 0);
                    }

                    if (sequence[i + 1] == sequence[i])
                    {
                        timesRepeated[sequence[i]]++;
                    }
                }
            }
            else
            {
                timesRepeated.Add(sequence[0], 0);
            }

            int mostRepeatedNumber = timesRepeated.OrderByDescending(e => e.Value).First().Key;
            int mostTimesRepeated = timesRepeated.OrderByDescending(e => e.Value).First().Value + 1;

            for (int i = 0; i < mostTimesRepeated; i++)
            {
                Console.Write($"{mostRepeatedNumber} ");
            }
        }
    }
}
