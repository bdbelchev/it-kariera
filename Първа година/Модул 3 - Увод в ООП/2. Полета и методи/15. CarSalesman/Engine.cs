using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.CarSalesman
{
    class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.model = model;
            this.power = power;
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

        public string Model
        {
            get { return model; }
        }

        public int Power
        {
            get { return power; }
        }

        public int Displacement
        {
            get { return displacement; }
        }

        public string Efficiency
        {
            get { return efficiency; }
        }
    }
}
