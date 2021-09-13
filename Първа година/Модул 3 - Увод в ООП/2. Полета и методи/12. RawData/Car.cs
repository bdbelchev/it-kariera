using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RawData
{
    class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;

        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            this.model = model;
            this.engine = engine;
            this.cargo = cargo;
            this.tires = tires;
        }

        public string Model
        {
            get { return model; }
        }

        public Engine Engine
        {
            get { return engine; }
        }

        public Cargo Cargo
        {
            get { return cargo; }
        }

        public Tire[] Tires
        {
            get { return tires; }
        }
    }
}
