using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Vehicles
{
    class Car : Vehicle
    {
        public Car(double fuel, double consumption) : base(fuel, consumption + 0.9)
        {
        }
    }
}
