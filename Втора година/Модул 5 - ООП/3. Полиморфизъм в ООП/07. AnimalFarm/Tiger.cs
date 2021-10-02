using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._AnimalFarm
{
    class Tiger : Feline
    {
        public Tiger(string name, string type, double weight, string livingRegion) : base(name, type, weight, livingRegion)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
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
