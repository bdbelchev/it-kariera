using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _12.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                string[] input = Console.ReadLine().Split();

                string carModel = input[0];

                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);

                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                double firstTirePressure = double.Parse(input[5]);
                int firstTireAge = int.Parse(input[6]);
                double secondTirePressure = double.Parse(input[7]);
                int secondTireAge = int.Parse(input[8]);
                double thirdTirePressure = double.Parse(input[9]);
                int thirdTireAge = int.Parse(input[10]);
                double fourthTirePressure = double.Parse(input[11]);
                int fourthTireAge = int.Parse(input[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tire firstTire = new Tire(firstTirePressure, firstTireAge);
                Tire secondTire = new Tire(secondTirePressure, secondTireAge);
                Tire thirdTire = new Tire(thirdTirePressure, thirdTireAge);
                Tire fourthTire = new Tire(fourthTirePressure, fourthTireAge);

                Car car = new Car(carModel, engine, cargo,
                    new[] { firstTire, secondTire, thirdTire, fourthTire });
                cars.Add(car);
            }

            switch (Console.ReadLine())
            {
                case "fragile":
                    foreach (Car car in cars
                        .Where(c => c.Cargo.Type == "fragile" &&
                                    c.Tires.Average(t => t.Pressure) < 1))
                    {
                        Console.WriteLine(car.Model);
                    }
                    break;
                case "flamable":
                    foreach (Car car in cars
                        .Where(c => c.Cargo.Type == "flamable"
                                    && c.Engine.Power > 250))
                    {
                        Console.WriteLine(car.Model);
                    }
                    break;
            }
        }
    }
}
