using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OCP.GoodExample.Interfaces;

namespace OCP.GoodExample.DiscountStrategies
{
    public class RegularCustomerDiscount : IDiscountStrategy
{
   public double CalculateDiscount(Order order)
   {
       return order.Amount * 0.1;
   }
}
}