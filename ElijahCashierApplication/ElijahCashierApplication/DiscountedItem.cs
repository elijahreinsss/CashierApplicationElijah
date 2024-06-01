using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElijahCashierApplication
{
    internal class DiscountedItem : Item
    {
        public double Discount { get; set; }

        public double GetDiscountedPrice()
        {
            return Price * (1 - Discount * 0.01);
        }
    }
}
