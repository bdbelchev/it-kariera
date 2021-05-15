using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pizzaData = Console.ReadLine().Split();

            Pizza pizza = new Pizza(pizzaData[1], int.Parse(pizzaData[2]));

            string[] doughData = Console.ReadLine().Split();

            try
            {
                Dough dough = new Dough(doughData[1], doughData[2], int.Parse(doughData[3]));
                pizza.Dough = dough;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            for (int i = 0; i < int.Parse(pizzaData[2]); i++)
            {
                string[] toppingData = Console.ReadLine().Split();

                try
                {
                    Topping topping = new Topping(toppingData[1], int.Parse(toppingData[2]));
                    pizza.AddTopping(topping);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }

            if (Console.ReadLine() == "END")
            {
                pizza.CalculateCalories();
                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
            }
        }
    }
}
