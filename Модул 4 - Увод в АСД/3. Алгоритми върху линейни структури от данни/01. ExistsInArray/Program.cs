using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExistsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int check = int.Parse(Console.ReadLine());

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] == check)
            //    {
            //        Console.WriteLine($"{check} Exists in the List");
            //        break;
            //    }
            //
            //    if (i == input.Length - 1 && input[i] != check)
            //    {
            //        Console.WriteLine($"{check} Not exists in the List");
            //    }
            //}

            Console.WriteLine(input.Contains(check) ?
                $"{check} Exists in the List" :
                $"{check} Not exists in the List");

            //Позволих си да пропусна някои задачи, защото се повтарят или са подобни на такива, решавани досега.
        }
    }
}
