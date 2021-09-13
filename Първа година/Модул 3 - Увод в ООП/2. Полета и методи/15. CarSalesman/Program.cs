using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            PopulateEngines(engines);
            PopulateCars(cars, engines);
            PrintInformation(cars);

        }

        private static void PrintInformation(Dictionary<string, Car> cars)
        {
            foreach (Car car in cars.Values)
            {
                Console.WriteLine($"{car.Model}:\n\t{car.Engine.Model}:\n\t\tPower: {car.Engine.Power}\n\t\tDisplacement: {(car.Engine.Displacement == 0 ? "n/a" : $"{car.Engine.Displacement}")}\n\t\tEfficiency: {car.Engine.Efficiency}\n\tWeight: {(car.Weight == 0 ? "n/a" : $"{car.Weight}")}\n\tColor: {car.Color}");
            }
        }

        private static void PopulateCars(Dictionary<string, Car> cars, Dictionary<string, Engine> engines)
        {
            int carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                string[] data = Console.ReadLine().Split();
                string model = data[0];
                Engine engine = engines[data[1]];
                int weight = 0;
                string color = "n/a";

                if (data.Length > 2)
                {
                    if (int.TryParse(data[2], out int result))
                    {
                        weight = result;

                        if (data.Length > 3)
                        {
                            color = data[3];
                        }
                    }
                    else
                    {
                        color = data[2];
                    }

                }

                Car car = new Car(model, engine, weight, color);
                cars.Add(model, car);
            }

        }

        private static void PopulateEngines(Dictionary<string, Engine> engines)
        {
            int engineCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < engineCount; i++)
            {
                string[] data = Console.ReadLine().Split();
                string model = data[0];
                int power = int.Parse(data[1]);
                int displacement = 0;
                string efficiency = "n/a";

                if (data.Length > 2)
                {
                    if (int.TryParse(data[2], out int result))
                    {
                        displacement = result;

                        if (data.Length > 3)
                        {
                            efficiency = data[3];
                        }
                    }
                    else
                    {
                        efficiency = data[2];
                    }

                }

                Engine engine = new Engine(model, power, displacement, efficiency);
                engines.Add(model, engine);
            }
        }
    }
}