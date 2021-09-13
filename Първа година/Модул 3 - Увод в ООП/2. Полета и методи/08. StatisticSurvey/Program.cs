using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07.OldestFamilyMember;

namespace _08.StatisticSurvey
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                people.AddPerson(person);
            }

            people.SortPeople();
            people.PrintPeople();
        }
    }
}
