using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP.GoodExample
{
   public interface IWorker
   {
       void Work();
       void Eat();
       void TakeBreak();
       void GetSalary();
   }

   public interface IDeveloper
   {
       void WriteSoftware();
       void FixBugs();
       void AttendMeeting();
   }

   public class Developer : IWorker, IDeveloper
   {
       public void Work() => Console.WriteLine("Çalışıyor");
       public void Eat() => Console.WriteLine("Yemek yiyor");
       public void TakeBreak() => Console.WriteLine("Mola veriyor");
       public void GetSalary() => Console.WriteLine("Maaş aldı");
       public void WriteSoftware() => Console.WriteLine("Kod yazıyor");
       public void FixBugs() => Console.WriteLine("Bug düzeltiyor");
       public void AttendMeeting() => Console.WriteLine("Toplantıya katıldı");
   }

   public class SecurityGuard : IWorker
   {
       public void Work() => Console.WriteLine("Çalışıyor");
       public void Eat() => Console.WriteLine("Yemek yiyor");
       public void TakeBreak() => Console.WriteLine("Mola veriyor");
       public void GetSalary() => Console.WriteLine("Maaş aldı");
   }
}