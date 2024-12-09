using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousMethod.Services
{
    public class LongRunningTaskService
    {
        // Eşzamanlı uzun süreli işlem
        public void PerformLongRunningTaskSynchronously()
        {
            Console.WriteLine("Starting synchronous task...");
            Thread.Sleep(3000); // 3 saniye beklet
            Console.WriteLine("Synchronous task completed.");
        }

        // Asenkron uzun süreli işlem
        public async Task PerformLongRunningTaskAsynchronously()
        {
            Console.WriteLine("Starting asynchronous task...");
            await Task.Delay(3000); // 3 saniye beklet
            Console.WriteLine("Asynchronous task completed.");
        }
    }
}