using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL
{
    class Program
    {
        public static async Task<long> Function1()
        {
            Stopwatch clock = new Stopwatch();
            clock.Start();
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("{0} - i={1}, Function1, Thread={2}", DateTime.UtcNow.ToString("HH:mm:ss.MM.ffff"), i, Thread.CurrentThread.ManagedThreadId);
            }
            clock.Stop();
            return clock.ElapsedMilliseconds;
        }

        public static async Task<long> Function2()
        {
            Stopwatch clock = new Stopwatch();
            clock.Start();
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("{0} - i={1}, Function2, Thread={2}", DateTime.UtcNow.ToString("HH:mm:ss.MM.ffff"), i, Thread.CurrentThread.ManagedThreadId);
            }
            clock.Stop();
            return clock.ElapsedMilliseconds;
        }

        public static async Task Run()
        {
            Task<long> t1 = Function1();
            Task<long> t2 = Function2();

            await Task.WhenAll(t2, t1);

            long time1 = t1.Result;
            long time2 = t2.Result;

            Console.WriteLine("time1 = {0}, time2 = {1}", time1, time2);
        }

        static void Main(string[] args)
        {
            Task t = Task.Factory.StartNew(() => Run());
            //Console.WriteLine(Task.Factory.Scheduler.MaximumConcurrencyLevel);
            Console.ReadKey();
        }
    }
}
