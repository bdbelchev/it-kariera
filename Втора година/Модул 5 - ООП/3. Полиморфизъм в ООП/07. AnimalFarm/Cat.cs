using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._AnimalFarm
{
    class Cat : Feline
    {
        private string breed;

        public Cat(string name, string type, double weight, string livingRegion, string breed) : base(name, type, weight, livingRegion)
        {
            this.breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override string ToString()
        {
            return $"{Type}[{Name}, {breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
