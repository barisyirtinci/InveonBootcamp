using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCP.BadExample
{
    public class OrderProcessor
    {
        public double CalculateDiscount(Order order, string customerType)
        {
            if (customerType == "Regular Type")
                return order.Amount * 0.1;
            else if (customerType == "Premium type")
                return order.Amount * 0.2;
            else if (customerType == "Vip type")
                return order.Amount * 0.3;
            return 0;
        }
    }

    public class Order
    {
        public double Amount { get; set; }
    }
}