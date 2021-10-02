using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._AnimalKingdom
{
    class Dog : IAnimal
    {
        public string MakeNoise()
        {
            return "Woof!";
        }

        public string MakeTrick()
        {
            return "Hold my paw, human!";
        }

        public void Perform()
        {
            Console.WriteLine(MakeNoise());
            Console.WriteLine(MakeTrick());
        }
    }
}
