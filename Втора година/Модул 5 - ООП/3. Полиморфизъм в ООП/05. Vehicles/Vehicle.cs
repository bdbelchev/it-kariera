using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Vehicles
{
    abstract class Vehicle
    {
        private double fuel;
        private double consumption;

        protected Vehicle(double fuel, double consumption)
        {
            this.fuel = fuel;
            this.consumption = consumption;
        }

        public double Fuel => this.fuel;

        public void Drive(double distance)
        {
            if (distance * consumption > fuel)
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
            else
            {
                fuel -= distance * consumption;
                Console.WriteLine($"{GetType().Name} traveled {distance} km");
            }
        }

        public virtual void Refuel(double liters)
        {
            fuel += liters;
        }
    }
}
