// OCP/Program.cs
namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            var order = new GoodExample.Order { Amount = 1000 };

            // Kötü örnek
            var badProcessor = new BadExample.OrderProcessor();
            Console.WriteLine($"regular indirim: {badProcessor.CalculateDiscount(new BadExample.Order { Amount = 1000 }, "Regular")}");
            Console.WriteLine($"premium indirim: {badProcessor.CalculateDiscount(new BadExample.Order { Amount = 1000 }, "Premium")}");

            // İyi örnek
            var regularProcessor = new GoodExample.OrderProcessor(new GoodExample.DiscountStrategies.RegularCustomerDiscount());
            var premiumProcessor = new GoodExample.OrderProcessor(new GoodExample.DiscountStrategies.PremiumCustomerDiscount());
            var vipProcessor = new GoodExample.OrderProcessor(new GoodExample.DiscountStrategies.VipCustomerDiscount());

            Console.WriteLine($"regular indirim: {regularProcessor.CalculateDiscount(order)}");
            Console.WriteLine($"regular indirim: {premiumProcessor.CalculateDiscount(order)}");
            Console.WriteLine($"vip indirim {vipProcessor.CalculateDiscount(order)}");

            var platinumProcessor = new GoodExample.OrderProcessor(new PlatinumCustomerDiscount());
            Console.WriteLine($"platinum tip indirim: {platinumProcessor.CalculateDiscount(order)}");
        }
    }

    public class PlatinumCustomerDiscount : GoodExample.Interfaces.IDiscountStrategy
    {
        public double CalculateDiscount(GoodExample.Order order)
        {
            return order.Amount * 0.4;
        }
    }
}