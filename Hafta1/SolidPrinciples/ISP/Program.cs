namespace ISP
{
   class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Kötü örnek:");
           try
           {
               BadExample.IWorker securityBad = new BadExample.SecurityGuard();
               securityBad.Work();
               securityBad.WriteSoftware();
           }
           catch (Exception ex)
           {
               Console.WriteLine($"Hata: {ex.Message}");
           }

           Console.WriteLine("\nİyi Örnek:");
           GoodExample.IWorker security = new GoodExample.SecurityGuard();
           security.Work();

           GoodExample.Developer developer = new GoodExample.Developer();
           developer.Work();
           developer.WriteSoftware();
       }
   }
}