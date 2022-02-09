using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._RoyalGambit
{
    interface IKillable
    {
        void OnKingAttack(object sender, EventArgs args);
    }
}
