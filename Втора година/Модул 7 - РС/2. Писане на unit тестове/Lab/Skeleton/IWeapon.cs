using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton
{
    public interface IWeapon
    {
        void Attack(ITarget target);
        int AttackPoints { get; }
        int DurabilityPoints { get; }
    }
}
