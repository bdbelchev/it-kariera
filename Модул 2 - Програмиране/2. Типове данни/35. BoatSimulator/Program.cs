using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.BoatSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char boat1 = char.Parse(Console.ReadLine());
            char boat2 = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int boat1pos = 0;
            int boat2pos = 0;

            for (int i = 1; i <= n; i++)
            {
                if (boat1pos >= 50 || boat2pos >= 50)
                {
                    break;
                }

                string command = Console.ReadLine();

                if (command == "UPGRADE")
                {
                    boat1 += (char)3;
                    boat2 += (char)3;
                    continue;
                }

                if (i % 2 != 0)
                {
                    boat1pos += command.Length;
                }
                else
                {
                    boat2pos += command.Length;
                }
            }

            if (boat1pos > boat2pos)
            {
                Console.WriteLine(boat1);
            }
            else if (boat2pos > boat1pos)
            {
                Console.WriteLine(boat2);
            }
        }
    }
}
