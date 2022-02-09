using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._RoyalGambit
{
    public delegate void AttackEventHandler(object sender, EventArgs args);

    class King
    {
        private string name;
        public event AttackEventHandler KingAttack;

        public King(string name)
        {
            this.name = name;
        }

        public void Attack()
        {
            Console.WriteLine($"King {name} is under attack!");
            KingAttack?.Invoke(this, EventArgs.Empty);
        }
    }
}
