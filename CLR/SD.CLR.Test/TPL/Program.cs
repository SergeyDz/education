using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    partial class Program
    {
        public static async Task Run()
        {
            await RunTaskParallelInvoke();
            await RunTaskStartSimple();
            await RunTaskWhenAll();
            await RunTaskFunctionAssignment();
            await RunTaskAwait();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Current Thread #: {0}", Thread.CurrentThread.ManagedThreadId);

            Run();
            //Console.WriteLine(Task.Factory.Scheduler.MaximumConcurrencyLevel);
            Console.ReadKey();

        }
    }
}
