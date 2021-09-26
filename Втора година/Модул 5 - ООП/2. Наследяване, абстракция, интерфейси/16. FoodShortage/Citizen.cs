using System;

namespace _16._FoodShortage
{
    class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        public string ID { get; }
        public string Name { get; }
        public int Age { get; }
        public DateTime Birthdate { get; }

        public Citizen(string name, int age, string id, DateTime birthdate)
        {
            ID = id;
            Name = name;
            Age = age;
            Birthdate = birthdate;
            Food = 0;
        }

        public int Food { get; set; }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
