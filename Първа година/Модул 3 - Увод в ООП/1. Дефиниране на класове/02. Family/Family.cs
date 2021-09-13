using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Family
{
    class Family
    {
        List<Person> people;

        public List<Person> People
        {
            get { return this.people; }
            set { this.people = value; }
        }

        public void Print()
        {
            People = People.OrderBy(p => p.Name).ToList();

            foreach (Person person in People)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }
        }
    }
}
