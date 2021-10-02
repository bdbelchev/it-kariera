using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._AnimalFarm
{
    abstract class Mammal : Animal
    {
        protected string LivingRegion { get; }

        protected Mammal(string name, string type, double weight, string livingRegion) : base(name, type, weight)
        {
            LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{Type}[{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
