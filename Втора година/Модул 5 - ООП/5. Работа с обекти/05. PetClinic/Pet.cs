using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._PetClinic
{
    class Pet
    {
        private string name;
        private int age;
        private string species;

        public Pet(string name, int age, string species)
        {
            Name = name;
            Age = age;
            Species = species;
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length > 50 || value.Any(char.IsDigit))
                {
                    throw new ArgumentException();
                }

                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            private set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException();
                }

                age = value;
            }
        }

        public string Species
        {
            get { return species; }
            private set { species = value; }
        }

        public override string ToString()
        {
            return $"{Name} {Age} {Species}";
        }
    }
}
