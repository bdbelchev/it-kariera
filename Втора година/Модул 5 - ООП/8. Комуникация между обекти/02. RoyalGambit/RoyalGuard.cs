using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._RoyalGambit
{
    class RoyalGuard : IKillable
    {
        private string name;

        public RoyalGuard(string name)
        {
            this.name = name;
        }

        public void OnKingAttack(object sender, EventArgs args)
        {
            Console.WriteLine($"Royal Guard {name} is defending!");
        }
    }
}
