using System;
using System.Linq;

namespace _07._AnimalFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animalData = Console.ReadLine().Split().ToArray();

            while (animalData[0] != "End")
            {
                string[] foodData = Console.ReadLine().Split().ToArray();

                Animal animal = GetAnimal(animalData);
                Food food = GetFood(foodData);

                animal.MakeSound();
                animal.Eat(food);
                Console.WriteLine(animal.ToString());

                animalData = Console.ReadLine().Split().ToArray();
            }
        }

        private static Animal GetAnimal(string[] animalData)
        {
            string animalType = animalData[0];
            string name = animalData[1];
            double weight = double.Parse(animalData[2]);
            string livingRegion = animalData[3];

            switch (animalType)
            {
                case "Cat":
                    {
                        string breed = animalData[4];
                        return new Cat(name, animalType, weight, livingRegion, breed);
                    }
                case "Tiger":
                    return new Tiger(name, animalType, weight, livingRegion);
                case "Mouse":
                    return new Mouse(name, animalType, weight, livingRegion);
                case "Zebra":
                    return new Zebra(name, animalType, weight, livingRegion);
                default:
                    throw new ArgumentException("Invalid animal type!");
            }
        }

        private static Food GetFood(string[] foodData)
        {
            string foodType = foodData[0];
            int quantity = int.Parse(foodData[1]);

            switch (foodType)
            {
                case "Vegetable":
                    return new Vegetable(quantity);
                case "Meat":
                    return new Meat(quantity);
                default:
                    throw new ArgumentException("Invalid food type!");
            }
        }
    }
}
