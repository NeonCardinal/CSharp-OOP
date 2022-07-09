using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Product
    {
        private string name;
        private decimal price;

        public string Name
        {
            get;
            set;
        }

        public decimal Price
        {
            get;
            set;
        }

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
