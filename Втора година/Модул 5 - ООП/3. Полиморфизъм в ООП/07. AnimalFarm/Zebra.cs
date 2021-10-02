using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._AnimalFarm
{
    class Zebra : Mammal
    {
        public Zebra(string name, string type, double weight, string livingRegion) : base(name, type, weight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Zs");
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
            {
                base.Eat(food);
            }
            else
            {
                Console.WriteLine($"{Type}s are not eating that type of food!");
            }
        }
    }
}
