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

    public class Lesson03 : ICommand
    {
        public delegate void ThreadExecutionDelegate(object interval); 

        public void ExecuteThread(object interval)
        {
            Console.WriteLine("{0} started.", Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Thread.Sleep(Int32.Parse(interval.ToString()));
                    Console.WriteLine("{0}: {1}. I = {2}, interval = {3}", DateTime.UtcNow.ToString("HH:mm:ss.ffff"), Thread.CurrentThread.ManagedThreadId, i, interval);
                }
                catch (ThreadAbortException e)
                {
                    Console.WriteLine("{0}: {1}. ThreadAbortException: {2}", DateTime.UtcNow.ToString("HH:mm:ss.ffff"), Thread.CurrentThread.ManagedThreadId, e.Message);
                    //Thread.ResetAbort();
                }
                catch (ThreadInterruptedException e)
                {
                    Console.WriteLine("{0}: {1}. ThreadInterruptedException: {2}", DateTime.UtcNow.ToString("HH:mm:ss.ffff"), Thread.CurrentThread.ManagedThreadId, e.Message);
                }
            }
            Console.WriteLine("{0} completed.", Thread.CurrentThread.ManagedThreadId);
        }

        public void AffectThread(object thread)
        {
            Thread t = thread as Thread;
            Thread.Sleep(5000);
            t.Interrupt();
        }

        public void Execute()
        {
            ThreadExecutionDelegate t1 = ExecuteThread;
            ThreadExecutionDelegate t2 = ExecuteThread;
            ThreadExecutionDelegate t3 = AffectThread;

            ParameterizedThreadStart s = new ParameterizedThreadStart(ExecuteThread);

            Thread thread1 = new Thread(new ParameterizedThreadStart(t1));
            Thread thread2 = new Thread(new ParameterizedThreadStart(t2));
            Thread thread3 = new Thread(new ParameterizedThreadStart(t3));

            thread1.Start(10000);
            thread2.Start(10000);
            thread3.Start(thread1);

            thread1.Join();
            thread3.Join();

        }
    }
}
