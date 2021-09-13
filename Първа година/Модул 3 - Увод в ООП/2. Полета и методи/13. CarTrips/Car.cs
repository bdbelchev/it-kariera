using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CarTrips
{
    class Car
    {
        private string model;
        private double fuel;
        private double fuelPerKm;
        private int mileage;

        public Car(string model, double fuel, double fuelPerKm)
        {
            this.model = model;
            this.fuel = fuel;
            this.fuelPerKm = fuelPerKm;
            this.mileage = 0;
        }

        public string Model
        {
            get { return model; }
        }

        public double Fuel
        {
            get { return fuel; }
        }

        public int Mileage
        {
            get { return mileage; }
        }

        public void Drive(int distance)
        {
            if (distance * fuelPerKm > fuel)
            {
                throw new ArgumentException("Insufficient fuel for the drive");
            }
            else
            {
                fuel -= distance * fuelPerKm;
                mileage += distance;
            }
        }
    }
}
