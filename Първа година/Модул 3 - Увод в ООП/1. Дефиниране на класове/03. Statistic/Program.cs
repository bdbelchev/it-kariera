using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Statistic
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Person[] people = new Person[count];

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();

                people[i] = new Person();
                people[i].Name = input[0];
                people[i].Age = int.Parse(input[1]);
            }

            List<Person> thirtyOrOlder = people.Where(p => p.Age >= 30)
                .OrderBy(p => p.Name).ToList();

            foreach (Person person in thirtyOrOlder)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
