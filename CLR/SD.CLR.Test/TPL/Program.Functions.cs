// <copyright file="Program.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>8/7/2014 3:02:49 PM</date>
// <summary></summary>
namespace TPL
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    partial class Program
    {
        public static async Task<long> Function1()
        {
            Stopwatch clock = new Stopwatch();
            clock.Start();
            for (int i = 0; i < 3; i++)
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
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("{0} - i={1}, Function2, Thread={2}", DateTime.UtcNow.ToString("HH:mm:ss.MM.ffff"), i, Thread.CurrentThread.ManagedThreadId);
            }
            clock.Stop();
            return clock.ElapsedMilliseconds;
        }

        public static async Task Function3()
        {
            Stopwatch clock = new Stopwatch();
            clock.Start();
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("{0} - i={1}, Function3, Thread={2}", DateTime.UtcNow.ToString("HH:mm:ss.MM.ffff"), i, Thread.CurrentThread.ManagedThreadId);
            }
            clock.Stop();
        }

        public static long Function4()
        {
            Stopwatch clock = new Stopwatch();
            clock.Start();
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("{0} - i={1}, Function2, Thread={2}", DateTime.UtcNow.ToString("HH:mm:ss.MM.ffff"), i, Thread.CurrentThread.ManagedThreadId);
            }
            clock.Stop();
            return clock.ElapsedMilliseconds;
        }
    }
}
