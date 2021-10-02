using System;
using System.Linq;

namespace _05._Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split().ToArray();
            string[] truckInfo = Console.ReadLine().Split().ToArray();
            string[] busInfo = Console.ReadLine().Split().ToArray();

            Car car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            Truck truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            Bus bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                switch (command[0])
                {
                    case "Drive":
                        switch (command[1])
                        {
                            case "Car":
                                car.Drive(double.Parse(command[2]));
                                break;
                            case "Truck":
                                truck.Drive(double.Parse(command[2]));
                                break;
                            case "Bus":
                                bus.Drive(double.Parse(command[2]));
                                break;
                        }
                        break;
                    case "Refuel":
                        switch (command[1])
                        {
                            case "Car":
                                car.Refuel(double.Parse(command[2]));
                                break;
                            case "Truck":
                                truck.Refuel(double.Parse(command[2]));
                                break;
                            case "Bus":
                                bus.Refuel(double.Parse(command[2]));
                                break;
                        }
                        break;
                    case "DriveEmpty":
                        bus.DriveEmpty(double.Parse(command[2]));
                        break;
                }
            }

            Console.WriteLine($"Car: {car.Fuel:f2}");
            Console.WriteLine($"Truck: {truck.Fuel:f2}");
            Console.WriteLine($"Bus: {bus.Fuel:f2}");
        }
    }
}
