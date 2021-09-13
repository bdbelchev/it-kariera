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

            Console.WriteLine(id);
        }

        private static long CheckID(long maxValue)
        {
            int n = int.Parse(Console.ReadLine());
            long result = 0;
            long oldID = 0;

            for (int i = 0; i < n; i++)
            {
                long id = long.Parse(Console.ReadLine());

                if (id <= maxValue && id > oldID)
                {
                    result = id;
                }

                oldID = id;
            }

            return result;
        }
    }
}
