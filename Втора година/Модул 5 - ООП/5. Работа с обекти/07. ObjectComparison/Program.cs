using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._ObjectComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string[] data = Console.ReadLine().Split().ToArray();

            while (data[0] != "END")
            {
                Person person = new Person(data[0], int.Parse(data[1]), data[2]);

                people.Add(person);

                data = Console.ReadLine().Split().ToArray();
            }

            int index = int.Parse(Console.ReadLine());
            Person personToCompare = people[index - 1];

            int equal = 0;
            int different = 0;

            foreach (Person person in people)
            {
                if (personToCompare.CompareTo(person) == 0)
                {
                    equal++;
                }
                else
                {
                    different++;
                }
            }

            Console.WriteLine(equal < 2 ? "No matches" : $"{equal} {different} {people.Count}");
        }
    }
}
