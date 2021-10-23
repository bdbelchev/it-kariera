using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerCompanySystem.Entities.Buildings
{
    public class Hotel : Building
    {
        public Hotel(string name, string city, int stars, double rentAmount) : base(name, city, stars, rentAmount)
        {
        }

        public override string Name
        {
            get { return base.Name; }
            protected set
            {
                if (!value.EndsWith("Hotel"))
                {
                    throw new ArgumentException("Name of hotel buildings should end on Hotel!");
                }

                base.Name = value;
            }
        }
    }
}
