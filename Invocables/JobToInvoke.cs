using System;
using Coravel.Invocable;
using System.Threading.Tasks;

namespace demo_dotnet_console_scheduler.Invocables
{
    public class JobToInvoke : IInvocable
    {
        public JobToInvoke()
        {
        }

        public async Task Invoke()
        {
            Console.WriteLine("The Job was invoked at " + DateTime.Now);
            await Task.CompletedTask;
        }
    }
}
