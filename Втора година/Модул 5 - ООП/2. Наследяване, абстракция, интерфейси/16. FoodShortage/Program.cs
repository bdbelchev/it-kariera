using System;
using System.Collections.Generic;
using System.Linq;

namespace _16._FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] data = Console.ReadLine().Split().ToArray();

                if (data.Length > 3)
                {
                    Citizen citizen = new Citizen(data[0], int.Parse(data[1]), data[2], Convert.ToDateTime(data[3]));
                    buyers.Add(data[0], citizen);
                }
                else
                {
                    Rebel rebel = new Rebel(data[0], int.Parse(data[1]), data[2]);
                    buyers.Add(data[0], rebel);
                }
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                if (buyers.ContainsKey(command))
                {
                    buyers[command].BuyFood();
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(buyers.Sum(b=>b.Value.Food));
        }
    }
}
