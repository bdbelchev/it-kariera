using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07.OldestFamilyMember;

namespace _08.StatisticSurvey
{
    class People
    {
        private List<Person> people;

        public void AddPerson(Person person)
        {
            if (people==null)
            {
                people = new List<Person>();
            }

            people.Add(person);
        }

        public void SortPeople()
        {
            people = people.Where(p => p.Age > 30).OrderBy(p => p.Name).ToList();
        }

        public void PrintPeople()
        {
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
