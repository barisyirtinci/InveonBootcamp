using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRP.BadExample
{
    public class CustomerManager
    {
        public void RegisterCustomer(string name, string email)
        {
            SaveCustomer(name, email);

            SendWelcomeMail(email);

            ExportToExcel(name, email);

            SendSMS(name);
        }

        private void SaveCustomer(string name, string email)
        {
            Console.WriteLine($"Müşteri kaydedildi: {name}");
        }

        private void SendWelcomeMail(string email)
        {
            Console.WriteLine($"Mail gönderildi: {email}");
        }

        private void ExportToExcel(string name, string email)
        {
            Console.WriteLine($"Excel'e eklendi: {name}");
        }

        private void SendSMS(string name)
        {
            Console.WriteLine($"SMS gönderildi: {name}");
        }
    }
}