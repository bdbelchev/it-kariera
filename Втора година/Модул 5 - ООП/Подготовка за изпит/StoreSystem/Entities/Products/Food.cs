﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Food : Product
{
    public Food(string name, int quantity, double deliverPrice, double percentageMarkup) : base(name, quantity, deliverPrice, percentageMarkup)
    {

    }

    public override double PercentageMarkup
    {
        get
        { return base.PercentageMarkup; }
        protected set
        {
            if (value > 100)
            {
                throw new ArgumentException("Food percentage markup cannot be above 100%!");
            }

            base.PercentageMarkup = value;
        }
    }
}
