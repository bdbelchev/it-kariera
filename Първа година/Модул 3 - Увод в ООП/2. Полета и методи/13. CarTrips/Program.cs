using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CarTrips
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            PopulateDictionary(cars);

            DriveCars(cars);

            PrintInfo(cars);

        }

        private static void PrintInfo(Dictionary<string, Car> cars)
        {
            foreach (Car car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:f2} {car.Mileage}");
            }
        }

        private static void DriveCars(Dictionary<string, Car> cars)
        {
            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                string model = command[1];
                int distance = int.Parse(command[2]);

                try
                {
                    cars[model].Drive(distance);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                command = Console.ReadLine().Split();
            }
        }

        private static void PopulateDictionary(Dictionary<string, Car> cars)
        {
            int carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                string[] carData = Console.ReadLine().Split();

                string model = carData[0];
                int fuel = int.Parse(carData[1]);
                double fuelPerKm = double.Parse(carData[2]);

                Car car = new Car(model, fuel, fuelPerKm);
                cars.Add(model, car);
            }
        }
    }
}
