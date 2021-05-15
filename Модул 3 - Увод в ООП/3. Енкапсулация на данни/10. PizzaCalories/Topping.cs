using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PizzaCalories
{
    class Topping
    {
        private string type;
        private int weight;
        private double calories;
        private string[] allowedTypes = new[] { "meat", "veggies", "cheese", "sauce" };

        public Topping(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
            this.calories = CalculateCalories();
        }

        private string Type
        {
            get { return type; }
            set
            {
                if (!allowedTypes.Contains(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        private int Weight
        {
            get { return weight; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [1...50].");
                }

                this.weight = value;
            }
        }

        public double Calories
        {
            get { return calories; }
        }

        private double CalculateCalories()
        {
            double baseCalories = 2 * this.weight;

            switch (type.ToLower())
            {
                case "meat":
                    baseCalories *= 1.2;
                    break;
                case "veggies":
                    baseCalories *= 0.8;
                    break;
                case "cheese":
                    baseCalories *= 1.1;
                    break;
                case "sauce":
                    baseCalories *= 0.9;
                    break;
            }

            return baseCalories;
        }
    }
}
