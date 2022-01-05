using System;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskCompSource = new TaskCompletionSource<bool>();

            var thread = new Thread(() =>
            {
                Thread.Sleep(1000);
                taskCompSource.TrySetResult(true);
            });

            Console.WriteLine(thread.ManagedThreadId);

            thread.Start();

            var test = taskCompSource.Task.Result;
        }
    }
}
