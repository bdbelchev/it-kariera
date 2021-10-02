namespace _05._Vehicles
{
    class Truck : Vehicle
    {
        public Truck(double fuel, double consumption, double capacity) : base(fuel, consumption + 1.6, capacity)
        {
        }

        public override void Refuel(double liters)
        {
            base.Refuel(0.95 * liters);
        }
    }
}
