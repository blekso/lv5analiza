using System;
using System.Collections.Generic;
using System.Text;

namespace lv5analiza.components
{
    //interface IBillable
    //{
    //    double Price { get; }
    //    string Description(int depth = 0);
    //}
    interface IShipable
    {
        double Price { get; }
        double Weight { get; }
        string Description(int depth = 0);
    }
}
