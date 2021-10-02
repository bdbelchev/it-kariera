using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Vehicles
{
    class Truck : Vehicle
    {
        public Truck(double fuel, double consumption) : base(fuel, consumption + 1.6)
        {
        }

        public override void Refuel(double liters)
        {
            base.Refuel(0.95 * liters);
        }
    }
}
