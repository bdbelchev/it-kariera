using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Google
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "End")
            {
                string personName = input[0];

                if (!people.ContainsKey(personName))
                {
                    people.Add(personName, new Person(personName));
                }

                switch (input[1])
                {
                    case "company":
                        string companyName = input[2];
                        string companyDivision = input[3];
                        double companySalary = double.Parse(input[4]);
                        Company company = new Company(companyName, companyDivision, companySalary);
                        people[personName].Company = company;
                        break;
                    case "pokemon":
                        string pokemonName = input[2];
                        string pokemonType = input[3];
                        Pokemon pokemon = new Pokemon(pokemonName, pokemonType);
                        people[personName].Pokemons.Add(pokemon);
                        break;
                    case "parents":
                        string parentName = input[2];
                        string parentDate = input[3];
                        ParentChild parent = new ParentChild(parentName, parentDate);
                        people[personName].Parents.Add(parent);
                        break;
                    case "children":
                        string childName = input[2];
                        string childDate = input[3];
                        ParentChild child = new ParentChild(childName, childDate);
                        people[personName].Children.Add(child);
                        break;
                    case "car":
                        string model = input[2];
                        int speed = int.Parse(input[3]);
                        Car car = new Car(model, speed);
                        people[personName].Car = car;
                        break;
                }

                input = Console.ReadLine().Split();
            }

            string personToPrint = Console.ReadLine();

            Console.WriteLine(people[personToPrint].ToString());
        }
    }
}
