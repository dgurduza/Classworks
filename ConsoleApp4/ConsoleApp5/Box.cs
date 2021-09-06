using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Box
    {
        public double PriceOfKilo { get; set; }
        public double Weight { get; set; }

        public Box(double weight,double price)
        {
            Weight = weight;
            PriceOfKilo = price;
        }
    }
}
