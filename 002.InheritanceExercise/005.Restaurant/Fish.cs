using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Fish : MainDish
    {
        private const double grams = 22;

        public double Grams
        {
            get
            {
                return grams;
            }
        }
        public Fish(string name, decimal price, double grams) : base(name, price, grams)
        {
        }
    }
}
