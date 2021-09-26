using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._BorderControl
{
    class Citizen : IIdentifiable
    {
        public string ID { get; }
        public string Name { get; }
        public int Age { get; }

        public Citizen(string id, string name, int age)
        {
            ID = id;
            Name = name;
            Age = age;
        }
    }
}
