namespace _05._Vehicles
{
    class Car : Vehicle
    {
        public Car(double fuel, double consumption, double capacity) : base(fuel, consumption + 0.9, capacity)
        {
        }
    }
}
