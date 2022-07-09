using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Bevarage : Product
    {
        private double milliliters;

        public double Milliliters
        {
            get;
            set;
        }
        public Bevarage(string name, decimal price, double milliliters) : base(name, price)
        {
            this.milliliters = milliliters;
        }
    }
}
