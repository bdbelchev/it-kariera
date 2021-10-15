using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> personSet1 = new SortedSet<Person>(new PersonComp1());
            SortedSet<Person> personSet2 = new SortedSet<Person>(new PersonComp2());

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split().ToArray();

                Person person = new Person(data[0], int.Parse(data[1]));

                personSet1.Add(person);
                personSet2.Add(person);
            }

            foreach (Person person in personSet1)
            {
                Console.WriteLine(person);
            }

            foreach (Person person in personSet2)
            {
                Console.WriteLine(person);
            }
        }
    }
}
