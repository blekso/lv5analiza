﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lv5analiza.components
{
    class Product : IShipable
    {
        private double price;
        private double weight;
        private string description;
        public Product(string description, double price, double weight)
        {
            this.description = description;
            this.price = price;
            this.weight = weight;
        }
        public double Price { get { return this.price; } }
        public double Weight { get { return this.weight; } }
        public string Description(int depth = 0)
        {
            return new string(' ', depth) + this.description;
        }
    }
}
