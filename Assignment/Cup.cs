using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Cup : IceCream
    {
        public Cup() { }
        public Cup(string option, int scoops, List<Flavour> flavours, List<Topping> toppings) 
            : base(option, scoops, flavours, toppings) { }

        public override double CalculatePrice()
        {
            double basePrice = 0.0;

            // Determine base price based on the ice cream option
            if (Option.ToLower() == "single")
            {
                basePrice = 4.00;
            }
            else if (Option.ToLower() == "double")
            {
                basePrice = 5.50;
            }
            else if (Option.ToLower() == "triple")
            {
                basePrice = 6.50;
            }
            else
            {
                // Handle unknown options
            }

            // Add $1 for each topping
            double toppingsPrice = Toppings.Count * 1.0;

            return basePrice + toppingsPrice;
        }

        public override string ToString()
        {
            return $"Cup: {base.ToString()}";
        }
    }
}
