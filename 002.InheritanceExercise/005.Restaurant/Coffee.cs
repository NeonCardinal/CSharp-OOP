using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double CoffeeMilliliters = 50;
        private const decimal CoffeePrice = 3.50M;

        public double Caffeine
        {
            get;
            set;
        }
        public Coffee(string name, decimal price, double milliliters) : base(name, CoffeePrice, CoffeeMilliliters)
        {
        }
    }
}
