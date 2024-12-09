using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LSP.GoodExample
{
   public abstract class Product
   {
       public abstract decimal GetPrice();
   }

   public class PhysicalProduct : Product
   {
       private decimal _basePrice = 100;
       private decimal _cargoPrice = 30;

       public override decimal GetPrice()
       {
           return _basePrice + _cargoPrice;
       }

       public void AddToStock(int quantity)
       {
           Console.WriteLine($"{quantity} adet fiziksel ürün stoğa eklendi");
       }
   }

   public class DigitalProduct : Product
   {
       private decimal _basePrice = 100;

       public override decimal GetPrice()
       {
           return _basePrice;
       }

       public void GenerateDownloadLink()
       {
           Console.WriteLine("İndirme linki oluşturuldu");
       }
   }
}