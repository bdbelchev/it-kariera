using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.CarSalesman
{
    class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine, int weight, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }

        public string Model
        {
            get { return model; }
        }

        public Engine Engine
        {
            get { return engine; }
        }

        public int Weight
        {
            get { return weight; }
        }

        public string Color
        {
            get { return color; }
        }
    }
}
