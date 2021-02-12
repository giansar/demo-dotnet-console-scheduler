using System;
using Microsoft.Extensions.Hosting;
using Coravel;
using Microsoft.Extensions.DependencyInjection;
using demo_dotnet_console_scheduler.Invocables;

namespace demo_dotnet_console_scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IHost host = Host.CreateDefaultBuilder(args).ConfigureServices(services =>
            {
                services.AddScheduler();
                services.AddTransient<JobToInvoke>();
            }).Build();

            host.Services.UseScheduler(scheduler =>
            {
                scheduler.Schedule<JobToInvoke>().EverySecond();
            });

            host.Run();
        }
    }
}
