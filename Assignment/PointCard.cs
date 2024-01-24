using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class PointCard
    {
        public int Points { get; set; }
        public int PunchCard { get; set; }
        public string Tier { get; set; }

        public PointCard() { }
        public PointCard(int p,int card)
        {
            Points = p;
            PunchCard = card;
        }

        int Total = 0;

        public void AddPoints(int Points)
        {
            Points += Convert.ToInt32(Math.Floor(Total * 0.72));
        }

        public double RedeemPoints(int Points)
        {
            if (Tier == "Silver" || Tier == "Gold")
            {
                double offsetAmt = Points * 0.02;
                return offsetAmt;

            }
            else { return 0.0; } // Return appropriate value for non-Silver or non-Gold tiers
        }

        private void AddFreeIceCream()
        {
            // Implementation for adding free ice cream
        }

        public void Punch()
        {
            PunchCard++;
            if (PunchCard >= 10)
            {
                AddFreeIceCream();

                // Reset the punch card
                PunchCard -=10;
            }
        }


        public override string ToString()
        {
            return "Points:" + Points +
                  " Punch Card: " + PunchCard +
                  " Tier: " + Tier;
        }

    }
}
