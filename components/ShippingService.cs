using System;
using System.Collections.Generic;
using System.Text;

namespace lv5analiza.components
{
    class ShippingService
    {
        private double price;

        public ShippingService(double price)
        {
            this.price = price;
        }
        public double CalculateShipping(Box box)
        {
            return box.Weight*price;
        }
    }
}
