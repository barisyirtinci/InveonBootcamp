namespace DIP
{
   class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("Kötü örnek:");
           var badService = new BadExample.NotificationService();
           badService.SendNotification("brsyrtnc@gmail.com", "Test mesajı");

           Console.WriteLine("\nİyi Örnek:");
           var emailService = new GoodExample.NotificationService(new GoodExample.EmailSender());
           emailService.SendNotification("brsyrtnc@gmail.com", "Email mesajı");

           var smsService = new GoodExample.NotificationService(new GoodExample.SmsSender());
           smsService.SendNotification("5388415811", "SMS mesajı");
       }
   }
}