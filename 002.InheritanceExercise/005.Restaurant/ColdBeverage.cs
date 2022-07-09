using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class ColdBeverage : Bevarage
    {
        public ColdBeverage(string name, decimal price, double milliliters) : base(name, price, milliliters)
        {
        }
    }
}
