using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Food : Product
    {
        private double grams;

        public double Grams
        {
            get;
            set;
        }
        public Food(string name, decimal price, double grams) : base(name, price)
        {
            this.grams = grams;
        }
    }
}
