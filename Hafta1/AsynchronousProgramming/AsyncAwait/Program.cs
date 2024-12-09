using AsyncAwait.Services;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Task Static Methods Example");

        var service = new TaskStaticMethodsService();

        service.RunTaskExample();

        await service.WhenAllExample();

        await service.WhenAnyExample();

        await service.DelayExample();
    }
}
