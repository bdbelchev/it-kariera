using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PizzaCalories
{
    class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int weight;
        private double calories;
        private string[] allowedTypes = new[] { "white", "wholegrain" };
        private string[] allowedTechniques = new[] { "crispy", "chewy", "homemade" };

        public Dough(string flourType, string bakingTechnique, int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
            this.calories = CalculateCalories();
        }

        private string FlourType
        {
            get { return flourType; }
            set
            {
                if (!allowedTypes.Contains(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        private string BakingTechnique
        {
            get { return bakingTechnique; }
            set
            {
                if (!allowedTechniques.Contains(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        private int Weight
        {
            get { return weight; }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1...200]");
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
            double baseCalories = 2 * weight;

            switch (flourType.ToLower())
            {
                case "white":
                    baseCalories *= 1.5;
                    break;
                case "wholegrain":
                    baseCalories *= 1.0;
                    break;
            }

            switch (bakingTechnique.ToLower())
            {
                case "crispy":
                    baseCalories *= 0.9;
                    break;
                case "chewy":
                    baseCalories *= 1.1;
                    break;
                case "homemade":
                    baseCalories *= 1.0;
                    break;
            }

            return baseCalories;
        }
    }
}
