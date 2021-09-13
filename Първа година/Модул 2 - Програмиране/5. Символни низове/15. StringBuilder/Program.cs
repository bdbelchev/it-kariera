using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string[] command = Console.ReadLine().Split(' ').ToArray();

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(inputString);

            switch (command[0])
            {
                case "Remove":
                    sb.Remove(int.Parse(command[1]), int.Parse(command[2]));
                    break;
                case "Insert":
                    sb.Insert(int.Parse(command[1]), command[2]);
                    break;
                case "Replace":
                    sb.Replace(command[1], command[2]);
                    break;
                case "Append":
                    sb.Append(command[1]);
                    break;
            }

            Console.WriteLine(sb);
        }
    }
}
