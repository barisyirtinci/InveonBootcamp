using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSP.BadExample
{
    public class Product
    {
        public virtual decimal GetPrice()
        {
            return 100;
        }

        public virtual void AddToStock(int quantity)
        {
            Console.WriteLine($"{quantity} adet ürün stoğa eklendi");
        }
    }

    public class PhysicalProduct : Product
    {
        public override decimal GetPrice()
        {
            return base.GetPrice() + 30;
        }
    }

    public class DigitalProduct : Product
    {
        public override void AddToStock(int quantity)
        {
            throw new NotImplementedException("Dijital ürünlerin stoğu olmaz!");
        }
    }
}