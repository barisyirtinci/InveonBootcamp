using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIP.BadExample
{
   public class EmailSender
   {
       public void SendEmail(string to, string message)
       {
           Console.WriteLine($"Email gönderildi: {to}, Mesaj: {message}");
       }
   }

   public class NotificationService
   {
       private readonly EmailSender _emailSender;

       public NotificationService()
       {
           _emailSender = new EmailSender();
       }

       public void SendNotification(string to, string message)
       {
           _emailSender.SendEmail(to, message);
       }
   }
}
