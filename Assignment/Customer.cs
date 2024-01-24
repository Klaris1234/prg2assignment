using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Customer
    {
        public string Name { get; set; }
        public int MemberId { get; set; }
        public DateTime Dob { get; set; }
        public Order CurrentOrder { get; set; }
        public List<Order> OrderHistory { get; set; } = new List<Order>();
        public PointCard rewards { get; set; }


        public Customer() { }
        public Customer(string n, int id, DateTime dob)
        {
            Name = n;
            MemberId = id;
            Dob = dob;
        }

        public Order MakeOrder()
        {
            Order newOrder = new Order();
            CurrentOrder = newOrder;
            return newOrder;
        }

        public bool IsBirthday()
        {
            return DateTime.Today == Dob.Date;
        }

        public override string ToString()
        {
            return "Name: " + Name +
                  " MemberID: " + MemberId +
                  " DOB: " + Dob;

        }

    }
}
