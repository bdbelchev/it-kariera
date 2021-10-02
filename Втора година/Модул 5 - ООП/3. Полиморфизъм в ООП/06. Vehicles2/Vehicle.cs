using System;

namespace _05._Vehicles
{
    abstract class Vehicle
    {
        private double fuel;
        private double consumption;
        private double capacity;

        protected Vehicle(double fuel, double consumption, double capacity)
        {
            this.consumption = consumption;
            this.capacity = capacity;
            Fuel = fuel;
        }

        public double Fuel
        {
            get => fuel;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }

                if (value > capacity)
                {
                    throw new ArgumentException("Cannot fit fuel in tank");
                }

                fuel = value;
            }
        }

        protected double Consumption => consumption;

        public virtual void Drive(double distance)
        {
            if (distance * consumption > Fuel)
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
            else
            {
                try
                {
                    Fuel -= distance * consumption;
                    Console.WriteLine($"{GetType().Name} traveled {distance} km");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public virtual void Refuel(double liters)
        {
            try
            {
                Fuel += liters;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
