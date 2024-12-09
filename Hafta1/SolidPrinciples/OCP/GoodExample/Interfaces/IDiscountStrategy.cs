using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCP.GoodExample.Interfaces
{
    public interface IDiscountStrategy
    {
        double CalculateDiscount(Order order);
    }
}