using System;

namespace _15._Birthday
{
    class Citizen : IIdentifiable, IBirthable
    {
        public string ID { get; }
        public string Name { get; }
        public int Age { get; }
        public DateTime Birthdate { get; }

        public Citizen(string id, string name, int age, DateTime birthdate)
        {
            ID = id;
            Name = name;
            Age = age;
            Birthdate = birthdate;
        }
    }
}
