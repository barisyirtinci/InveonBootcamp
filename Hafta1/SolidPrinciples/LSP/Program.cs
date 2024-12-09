namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kötü örnek:");
            try
            {
                BadExample.Product physicalBad = new BadExample.PhysicalProduct();
                BadExample.Product digitalBad = new BadExample.DigitalProduct();

                physicalBad.AddToStock(5);
                digitalBad.AddToStock(5);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
            }

            Console.WriteLine("\nİyi örnek:");
            GoodExample.Product physical = new GoodExample.PhysicalProduct();
            GoodExample.Product digital = new GoodExample.DigitalProduct();

            Console.WriteLine($"Fiziksel ürün fiyatı: {physical.GetPrice()}");
            Console.WriteLine($"Dijital ürün fiyatı: {digital.GetPrice()}");

            var physicalProduct = (GoodExample.PhysicalProduct)physical;
            physicalProduct.AddToStock(5);

            var digitalProduct = (GoodExample.DigitalProduct)digital;
            digitalProduct.GenerateDownloadLink();
        }
    }
}