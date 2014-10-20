// <copyright file="Lesson01.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>8/17/2014 10:41:29 AM</date>
// <summary></summary>
namespace MultiThreading.Lessons
{
    using CLR.Common.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class Lesson02 : ICommand
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

            t1.BeginInvoke(null, null);
            t2.BeginInvoke(null, null);
            t3.Invoke();
        }
    }
}
