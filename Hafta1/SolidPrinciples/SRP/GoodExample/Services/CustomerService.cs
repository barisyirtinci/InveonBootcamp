using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SRP.GoodExample.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void SaveCustomer(Customer customer)
        {
            _customerRepository.Save(customer);
        }
    }
}

// SRP/GoodExample/Services/EmailService.cs 
public class EmailService
{
    public void SendWelcomeEmail(string email)
    {
        Console.WriteLine($"Mail gönderildi: {email}");
    }
}

// SRP/GoodExample/Services/ExcelExportService.cs
public class ExcelExportService
{
    public void ExportCustomer(Customer customer)
    {
        Console.WriteLine($"Excel'e aktarıldı: {customer.Name}");
    }
}

// SRP/GoodExample/Services/SmsService.cs
public class SmsService
{
    public void SendSms(string phone)
    {
        Console.WriteLine($"SMS gönderildi: {phone}");
    }
}

// SRP/GoodExample/Models/Customer.cs
public class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}

// SRP/GoodExample/Repositories/ICustomerRepository.cs
public interface ICustomerRepository
{
    void Save(Customer customer);
}

// SRP/GoodExample/Repositories/CustomerRepository.cs
public class CustomerRepository : ICustomerRepository
{
    public void Save(Customer customer)
    {
        Console.WriteLine($"Müşteri kaydedildi: {customer.Name}");
    }
}