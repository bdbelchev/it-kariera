using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int fullCourses = people / capacity;

            if (people % capacity != 0)
            {
                fullCourses++;
            }

            Console.WriteLine(fullCourses);
        }
    }
}
