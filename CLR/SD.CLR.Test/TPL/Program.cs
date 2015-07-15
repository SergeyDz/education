using CLR.Common.Contracts;
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
            //await RunTaskParallelInvoke();
            //await RunTaskStartSimple();
            //await RunTaskWhenAll();
            //await RunTaskFunctionAssignment();
            //await RunTaskAwait();
            //await TaskCollectionWithCustomDataLambda();
            //await AttachToParent();

            //BasicExample example = new BasicExample();
            //Task.Run( () => example.Run());
            Stopwatch watch = new Stopwatch();
            watch.Start();
            var command = new Lessons.Lesson04();
            await command.Execute();
            watch.Stop();
            Console.WriteLine("================= Total time: {0} =======================", watch.Elapsed);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Thread:{0}.    | Start", Thread.CurrentThread.ManagedThreadId);

            Run();
            //Console.WriteLine(Task.Factory.Scheduler.MaximumConcurrencyLevel);
            Console.ReadKey();

        }
    }
}
