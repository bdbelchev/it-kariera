using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._FoodShortage
{
    class Rebel : IBuyer
    {
        private string name;
        private int age;
        private string group;

        public Rebel(string name, int age, string group)
        {
            this.name = name;
            this.age = age;
            this.group = group;
            Food = 0;
        }

        public int Food { get; set; }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
