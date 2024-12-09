
using SRP.GoodExample.Services;

namespace SRP
{
   class Program
   {
       static void Main(string[] args)
       {
           var customerRepository = new CustomerRepository();
           var customerService = new CustomerService(customerRepository);
           var emailService = new EmailService();
           var excelService = new ExcelExportService();
           var smsService = new SmsService();

           var customer = new Customer
           {
               Name = "Barış Yırtıncı",
               Email = "brsyrtnc@gmail.com",
               Phone = "5388415811"
           };

           customerService.SaveCustomer(customer);
           emailService.SendWelcomeEmail(customer.Email);
           excelService.ExportCustomer(customer);
           smsService.SendSms(customer.Phone);

           var badManager = new BadExample.CustomerManager();
           badManager.RegisterCustomer("Barış Yırtıncı", "brsyrtnc@gmail.com");
       }
   }
}