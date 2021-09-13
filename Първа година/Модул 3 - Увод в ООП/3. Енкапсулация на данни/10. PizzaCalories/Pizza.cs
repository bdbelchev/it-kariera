using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PizzaCalories
{
    class Pizza
    {
        private string name;
        private List<Topping> toppings;
        private Dough dough;
        private double totalCalories;
        private int toppingCount;

        public Pizza(string name, int toppingCount)
        {
            this.Name = name;
            this.ToppingCount = toppingCount;
            this.toppings = new List<Topping>(ToppingCount);
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public Dough Dough
        {
            get { return dough; }
            set { this.dough = value; }
        }

        public int ToppingCount
        {
            get { return toppingCount; }
            set
            {
                if (value > 10 || value < 1)
                {
                    throw new ArgumentException("Number of toppings should be in range [0...10].");
                }

                this.toppingCount = value;
            }
        }

        public double TotalCalories
        {
            get { return totalCalories; }
        }

        public void AddTopping(Topping topping)
        {
            this.toppings.Add(topping);
        }

        public void CalculateCalories()
        {
            this.totalCalories = this.dough.Calories + this.toppings.Sum(t => t.Calories);
        }
    }
}
