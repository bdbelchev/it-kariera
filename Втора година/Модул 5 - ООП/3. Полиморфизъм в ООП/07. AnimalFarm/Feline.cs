using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._AnimalFarm
{
    abstract class Feline : Mammal
    {
        protected Feline(string name, string type, double weight, string livingRegion) : base(name, type, weight, livingRegion)
        {
        }
    }
}
