﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Order
    {
        public int Id { get; set; }
        public DateTime TimeRecieved { get; set; }
        public DateTime? TimeFulfilled { get; set; }
        public List<IceCream> IceCreamList { get; set; }

        public Order() { }
        public Order(int id, DateTime timeR)
        {
            Id = id;
            TimeRecieved = timeR;
        }
        public void ModifyIceCream(int index)
        {
            /*if (iceCreamIndex >= 0 && iceCreamIndex < IceCreamList.Count)
             {
                 IceCreamList[iceCreamIndex] = modifiedIceCream;
             }
             else
             {
                 // Handle index out of range error
             }*/
        }

        public void AddIceCream(IceCream newIceCream)
        {
            IceCreamList.Add(newIceCream);
        }

        public void DeleteIceCream(int index)
        {
            if (index >= 0 && index < IceCreamList.Count)
            {
                IceCreamList.RemoveAt(index);
                Console.WriteLine("successfully removed");
                
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }

        public double CalculateTotal()
        {
            double total = 0.0;
            foreach (var iceCream in IceCreamList)
            {
                total += iceCream.CalculatePrice();
            }
            return total;
        }

        public override string ToString()
        {
            return "ID:" + Id +
                  " Time Recieved: " + TimeRecieved +
                  " Time Fulfilled: " + TimeFulfilled +
                  " Ice Cream List: " + IceCreamList;
        }

    }
}

  