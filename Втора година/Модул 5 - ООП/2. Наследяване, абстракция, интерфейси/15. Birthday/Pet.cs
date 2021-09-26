using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._Birthday
{
    class Pet : IBirthable
    {
        public string Name { get; }
        public DateTime Birthdate { get; }

        public Pet(string name, DateTime birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }
    }
}
