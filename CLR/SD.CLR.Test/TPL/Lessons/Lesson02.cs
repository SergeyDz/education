using CLR.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL.Lessons
{
    class Lesson02 
    {
        public async Task Execute()
        {
            Task.Factory.StartNew(
                () => {
                    Console.WriteLine("Thread: {0} started as main.", Thread.CurrentThread.ManagedThreadId);


                    Task.Factory.StartNew(() => {
                        Console.WriteLine("Thread: {0} started as child 1.", Thread.CurrentThread.ManagedThreadId);
                    });
                    Task.Factory.StartNew(() =>
                    {
                        Console.WriteLine("Thread: {0} started as child 2.", Thread.CurrentThread.ManagedThreadId);
                    });
                    Task.Factory.StartNew(() =>
                    {
                        Console.WriteLine("Thread: {0} started as child 3.", Thread.CurrentThread.ManagedThreadId);
                    });
                    Task.Factory.StartNew(() =>
                    {
                        Console.WriteLine("Thread: {0} started as child 4.", Thread.CurrentThread.ManagedThreadId);
                    }, TaskCreationOptions.AttachedToParent);
                    Task.Factory.StartNew(() =>
                    {
                        Console.WriteLine("Thread: {0} started as child 5.", Thread.CurrentThread.ManagedThreadId);
                    }, TaskCreationOptions.AttachedToParent);

                    Thread.Sleep(1000);
                }
                );
        }
    }
}
