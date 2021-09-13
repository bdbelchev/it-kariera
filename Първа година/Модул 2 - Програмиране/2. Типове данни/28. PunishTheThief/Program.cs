using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.CatchTheThief
{
    class Program
    {
        static void Main(string[] args)
        {
            string idType = Console.ReadLine();
            long id = 0;

            switch (idType)
            {
                case "sbyte":
                    id = CheckID(sbyte.MaxValue);
                    break;
                case "int":
                    id = CheckID(int.MaxValue);
                    break;
                case "long":
                    id = CheckID(long.MaxValue);
                    break;
            }

            int sentence = CalculateSentence(id);

            Console.WriteLine(sentence == 1
                ? $"Prisoner with id {id} is sentenced to {sentence} year"
                : $"Prisoner with id {id} is sentenced to {sentence} years");
        }

        private static int CalculateSentence(long id)
        {
            double sentence = id < 0 ? id / -128.0 : id / 127.0;
            return (int)Math.Ceiling(sentence);
        }

        private static long CheckID(long maxValue)
        {
            int n = int.Parse(Console.ReadLine());
            long oldID = long.MinValue;
            long result = oldID;

            for (int i = 0; i < n; i++)
            {
                long id = long.Parse(Console.ReadLine());

                if (id <= maxValue && id > oldID && id > result)
                {
                    result = id;
                }

                oldID = id;
            }

            return result;
        }
    }
}