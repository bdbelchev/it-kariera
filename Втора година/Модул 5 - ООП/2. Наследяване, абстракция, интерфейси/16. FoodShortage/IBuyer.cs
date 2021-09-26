using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._FoodShortage
{
    interface IBuyer
    {
        public int Food { get; set; }

        void BuyFood();
    }
}
