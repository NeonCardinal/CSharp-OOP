using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Dessert : Food
    {
        private double calories;

        public double Calories
        {
            get;
            set;
        }
        public Dessert(string name, decimal price, double grams, double calories) : base(name, price, grams)
        {
            this.calories = calories;
        }
    }
}
