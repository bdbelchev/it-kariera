using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._Cars
{
    class Tesla : ICar, IElectricCar
    {
        public string Model { get; }
        public string Color { get; }
        public int Battery { get; }

        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{Color} {nameof(Tesla)} {Model} with {Battery} Batteries";
        }
    }
}
