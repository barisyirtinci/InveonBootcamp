using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIP.GoodExample
{
   public interface IMessageSender
   {
       void SendMessage(string to, string message);
   }

   public class EmailSender : IMessageSender
   {
       public void SendMessage(string to, string message)
       {
           Console.WriteLine($"Email gönderildi: {to}, Mesaj: {message}");
       }
   }

   public class SmsSender : IMessageSender
   {
       public void SendMessage(string to, string message)
       {
           Console.WriteLine($"SMS gönderildi: {to}, Mesaj: {message}");
       }
   }

   public class NotificationService
   {
       private readonly IMessageSender _messageSender;

       public NotificationService(IMessageSender messageSender)
       {
           _messageSender = messageSender;
       }

       public void SendNotification(string to, string message)
       {
           _messageSender.SendMessage(to, message);
       }
   }
}