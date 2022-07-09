using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double grams = 250;
        private const double calories = 1000;
        private const decimal cakePrice = 2.50M;

        //public double Grams
        //{
        //    get;
        //}

        public double Calories
        {
            get;
        }

        //public decimal CakePrice
        //{
        //    get;
        //}

        public Cake(string name, decimal price, double grams, double calories) : base(name, price, grams, calories)
        {
            this.Calories = calories;
        }
    }
}
