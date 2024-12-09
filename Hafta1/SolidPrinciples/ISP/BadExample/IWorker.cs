using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP.BadExample
{
   public interface IWorker
   {
       void Work();
       void Eat();
       void TakeBreak();
       void GetSalary();
       void WriteSoftware();
       void AttendMeeting();
       void FixBugs();
   }

   public class Developer : IWorker
   {
       public void Work() => Console.WriteLine("Çalışıyor");
       public void Eat() => Console.WriteLine("Yemek yiyor");
       public void TakeBreak() => Console.WriteLine("Mola veriyor");
       public void GetSalary() => Console.WriteLine("Maaş aldı");
       public void WriteSoftware() => Console.WriteLine("Kod yazıyor");
       public void AttendMeeting() => Console.WriteLine("Toplantıya katıldı");
       public void FixBugs() => Console.WriteLine("Bug düzeltiyor");
   }

   public class SecurityGuard : IWorker
   {
       public void Work() => Console.WriteLine("Çalışıyor");
       public void Eat() => Console.WriteLine("Yemek yiyor");
       public void TakeBreak() => Console.WriteLine("Mola veriyor");
       public void GetSalary() => Console.WriteLine("Maaş aldı");
       public void WriteSoftware() => throw new NotImplementedException();
       public void AttendMeeting() => throw new NotImplementedException();
       public void FixBugs() => throw new NotImplementedException();
   }
}