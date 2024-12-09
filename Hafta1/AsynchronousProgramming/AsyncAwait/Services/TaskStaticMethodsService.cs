namespace AsyncAwait.Services
{
    public class TaskStaticMethodsService
    {
        public void RunTaskExample()
        {
            Console.WriteLine("Task.Run example started.");
            Task task = Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Task running: {i}");
                    Task.Delay(500).Wait();
                }
            });
            task.Wait();
            Console.WriteLine("Task.Run example completed.");
        }


        public async Task WhenAllExample()
        {
            Console.WriteLine("Task.WhenAll example started.");
            List<Task> tasks = new List<Task>
            {
                Task.Delay(1000),
                Task.Delay(2000),
                Task.Delay(3000)
            };

            await Task.WhenAll(tasks);
            Console.WriteLine("All tasks in Task.WhenAll are completed.");
        }

        public async Task WhenAnyExample()
        {
            Console.WriteLine("Task.WhenAny example started.");
            List<Task> tasks = new List<Task>
            {
                Task.Delay(1000),
                Task.Delay(2000),
                Task.Delay(3000)
            };

            Task firstCompleted = await Task.WhenAny(tasks);
            Console.WriteLine("First completed task in Task.WhenAny.");
        }

        public async Task DelayExample()
        {
            Console.WriteLine("Task.Delay example started.");
            await Task.Delay(2000);
            Console.WriteLine("Task.Delay completed after 2 seconds.");
        }
    }
}
