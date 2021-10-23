﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerCompanySystem.Entities.Buildings
{
    public class Residence : Building
    {
        public Residence(string name, string city, int stars, double rentAmount) : base(name, city, stars, rentAmount)
        {
        }

        public override string Name
        {
            get { return base.Name; }
            protected set
            {
                if (!value.EndsWith("Residence"))
                {
                    throw new ArgumentException("Name of residence buildings should end on Residence!");
                }

                base.Name = value;
            }
        }
    }
}
