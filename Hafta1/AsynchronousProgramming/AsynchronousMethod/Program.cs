using System.Diagnostics;
using AsynchronousMethod.Services;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Asynchronous Method Example");

        // Servis örneği oluştur
        var service = new LongRunningTaskService();

        // Zaman ölçer
        Stopwatch stopwatch = new Stopwatch();

        // Eşzamanlı metodu çalıştır
        stopwatch.Start();
        service.PerformLongRunningTaskSynchronously();
        stopwatch.Stop();
        Console.WriteLine($"Synchronous method took: {stopwatch.ElapsedMilliseconds} ms");

        // Asenkron metodu çalıştır
        stopwatch.Restart();
        await service.PerformLongRunningTaskAsynchronously();
        stopwatch.Stop();
        Console.WriteLine($"Asynchronous method took: {stopwatch.ElapsedMilliseconds} ms");
    }
}
