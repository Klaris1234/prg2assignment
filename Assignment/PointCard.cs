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
        public AddPoints(int Points)
        {
            Points += Math.Floor(Total * 0.72);
        }

        public RedeemPoints(int Points)
        {
            if (Tier == "Silver" || Tier == "Gold")
            {
                double offsetamt = Points * 0.02;
                return offsetamt;

            }
            else { return false; }
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
