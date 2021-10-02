using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split().ToArray();
            string[] truckInfo = Console.ReadLine().Split().ToArray();

            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
            Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                switch (command[0])
                {
                    case "Drive":
                        if (command[1] == "Car")
                        {
                            car.Drive(double.Parse(command[2]));
                        }
                        else
                        {
                            truck.Drive(double.Parse(command[2]));
                        }
                        break;
                    case "Refuel":
                        if (command[1] == "Car")
                        {
                            car.Refuel(double.Parse(command[2]));
                        }
                        else
                        {
                            truck.Refuel(double.Parse(command[2]));
                        }
                        break;
                }
            }

            Console.WriteLine($"Car: {car.Fuel:f2}");
            Console.WriteLine($"Truck: {truck.Fuel:f2}");
        }
    }
}
