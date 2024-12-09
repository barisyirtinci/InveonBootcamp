using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OCP.GoodExample.Interfaces;

namespace OCP.GoodExample
{
    public class OrderProcessor
    {
        private readonly IDiscountStrategy _discountStrategy;

        public OrderProcessor(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public double CalculateDiscount(Order order)
        {
            return _discountStrategy.CalculateDiscount(order);
        }
    }
}