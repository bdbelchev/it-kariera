using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> sortedSet = new SortedSet<Person>();
            HashSet<Person> hashSet = new HashSet<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split().ToArray();

                Person person = new Person(data[0], int.Parse(data[1]));

                sortedSet.Add(person);
                hashSet.Add(person);
            }

            sortedSet = new SortedSet<Person>(sortedSet.Distinct());
            hashSet = new HashSet<Person>(hashSet.Distinct());

            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count); // :(

            //TODO: Да проуча и оправя GetHashCode
        }
    }
}
