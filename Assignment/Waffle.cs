using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Waffle : IceCream
    {
        public string WaffleFlavour { get; set; }
        public Waffle() { }
        public Waffle(string option, int scoops, List<Flavour> flavours, List<Topping> toppings, string waffleFlavour)
            : base(option, scoops, flavours, toppings)
        {
            WaffleFlavour = waffleFlavour;
        }

        public override double CalculatePrice()
        {
            double basePrice = 0.0;

            // Determine base price based on the ice cream option
            if (Option.ToLower() == "single")
            {
                basePrice = 7.00;
            }
            else if (Option.ToLower() == "double")
            {
                basePrice = 8.50;
            }
            else if (Option.ToLower() == "triple")
            {
                basePrice = 9.50;
            }
            else
            {
                // Handle unknown options
            }

            // Add $1 for each topping
            double toppingsPrice = Toppings.Count * 1.0;

            // Add $3 for a red velvet, charcoal, or pandan waffle
            if (new[] { "red velvet", "charcoal", "pandan" }.Contains(WaffleFlavour.ToLower()))
            {
                toppingsPrice += 3.0;
            }

            return basePrice + toppingsPrice;
        }

        public override string ToString()
        {
            return $"Waffle: {base.ToString()}, Waffle Flavour: {WaffleFlavour}";
        }
    }
}

