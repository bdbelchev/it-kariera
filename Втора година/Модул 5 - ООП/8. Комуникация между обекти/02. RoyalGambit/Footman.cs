using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._RoyalGambit
{
    class Footman : IKillable
    {
        private string name;

        public Footman(string name)
        {
            this.name = name;
        }

        public void OnKingAttack(object sender, EventArgs args)
        {
            Console.WriteLine($"Footman {name} is panicking!");
        }
    }
}
