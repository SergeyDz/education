// <copyright file="Lesson04.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>8/18/2014 7:13:06 AM</date>
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

    [Serializable]
    public class Lesson04 : ICommand
    {
        public void ExecuteThread(object o)
        {
            Console.WriteLine("{0} started.", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("{0}: {1}. ", DateTime.UtcNow.ToString("HH:mm:ss.ffff"), Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(500);
            Console.WriteLine("{0} completed.", Thread.CurrentThread.ManagedThreadId);
        }

        public void Execute()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(new ParameterizedThreadStart(ExecuteThread));
                t.Start();
            }

            Thread.Sleep(500);
            Console.WriteLine(" --------------------- Pool ------------------------------------");
            int t1, t2;

            ThreadPool.GetMaxThreads(out t1, out t2);
            Console.WriteLine("workedThreads = {0}, completionThreads={1}", t1, t2);
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(ExecuteThread);
            }
        }
    }
}
