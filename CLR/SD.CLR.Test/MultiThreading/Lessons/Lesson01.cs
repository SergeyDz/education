// <copyright file="Lesson01.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>8/17/2014 10:41:29 AM</date>
// <summary></summary>
namespace MultiThreading.Lessons
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using CLR.Common.Contracts;

    public class Lesson01 : ICommand
    {
        public delegate void ThreadExecutionDelegate(); 

        public void ExecuteThread()
        {
            Random random = new Random();
            int interval = random.Next(1, 100);
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(interval);
                Console.WriteLine("{0}. I = {1}", Thread.CurrentThread.ManagedThreadId, i);
            }
        }

        public void Execute()
        {
            ThreadExecutionDelegate t1 = ExecuteThread;
            ThreadExecutionDelegate t2 = ExecuteThread;
            ThreadExecutionDelegate t3 = ExecuteThread;

            Thread thread1 = new Thread(new ThreadStart(t1));
            Thread thread2 = new Thread(new ThreadStart(t2));
            Thread thread3 = new Thread(new ThreadStart(t3));

            thread1.Start();
            thread2.Start();
            thread3.Start();

            t1();
        }
    }
}
