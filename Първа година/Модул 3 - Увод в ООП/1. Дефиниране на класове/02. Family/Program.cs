using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Family
{
    class Program
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                Person person = new Person();
                person.Name = name;
                person.Age = age;

                if (family.People==null)
                {
                    family.People = new List<Person>();
                }

                family.People.Add(person);
            }

            family.Print();
        }
    }
}
