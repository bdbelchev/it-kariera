using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._AnimalFarm
{
    abstract class Animal
    {
        protected string Name { get; }
        protected string Type { get; }
        protected double Weight { get; }
        protected int FoodEaten { get; private set; }

        protected Animal(string name, string type, double weight)
        {
            Name = name;
            Type = type;
            Weight = weight;
        }

        public abstract void MakeSound();

        public virtual void Eat(Food food)
        {
            FoodEaten += food.Quantity;
        }
    }
}
