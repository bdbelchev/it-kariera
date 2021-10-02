using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._AnimalFarm
{
    abstract class Food
    {
        public int Quantity { get; }

        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }
    }
}
