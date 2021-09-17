using System;
using System.Linq;

namespace _02._Family
{
    class Program
    {
        static void Main(string[] args)
        {
            Family myFamily = new Family();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                Person person = new Person(name, age);

                myFamily.People.Add(person);
            }

            foreach (Person person in myFamily.People.OrderBy(p => p.Name))
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }
    }
}
