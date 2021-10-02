using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace _05._Vehicles
{
    class Bus : Vehicle
    {
        public Bus(double fuel, double consumption, double capacity) : base(fuel, consumption, capacity)
        {
        }

        public override void Drive(double distance)
        {
            if (distance * (Consumption + 1.4) > Fuel)
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
            else
            {
                try
                {
                    Fuel -= distance * (Consumption + 1.4);
                    Console.WriteLine($"{GetType().Name} traveled {distance} km");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public void DriveEmpty(double distance)
        {
            base.Drive(distance);
        }
    }
}
