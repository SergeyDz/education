// <copyright file="Prohram.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>8/8/2014 10:45:28 AM</date>
// <summary></summary>
namespace TPL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using TPL.DomainModel;

    partial class Program
    {
        private static async Task TaskCollectionWithCustomDataLambda()
        {
            Task[] tasks = new Task[10];

            for (int i = 0; i < 10; i++)
            {
                tasks[i] = Task.Factory.StartNew(
                        (object x) =>
                        {
                            CustomTaskData data = x as CustomTaskData;
                            if (data == null)
                                return;
                            data.ThreadId = Thread.CurrentThread.ManagedThreadId;
                            Console.WriteLine("i={0}, Task Id={1}, ThreadId={2}", data.Index, data.TaskId, data.ThreadId);
                        },
                        new CustomTaskData()
                        {
                            Index = i
                        }
                    ).ContinueWith<CustomTaskData>((x) => {
                        CustomTaskData data =  x.AsyncState as CustomTaskData;
                        if(data == null)
                            return new CustomTaskData();
                        Console.WriteLine("Continue with i={0}, Thread={1}", data.Index, Thread.CurrentThread.ManagedThreadId);
                        return data;
                    });
            }
            
            await Task.WhenAll(tasks);

            Console.WriteLine("foreach results");
            foreach (var task in tasks)
            {
                CustomTaskData data = ((Task<CustomTaskData>)task).Result;
                Console.WriteLine("i={0}, Task Id={1}, ThreadId={2}", data.Index, data.TaskId, data.ThreadId);
            }

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -");
        }

        private static async Task AttachToParent()
        {
            var t= Task.Factory.StartNew(
                    () =>
                    {
                        Console.WriteLine("Main task started");

                        Task.Factory.StartNew(
                                () =>
                                {
                                    Console.WriteLine("Child task started");
                                    Console.WriteLine("Child task completed");
                                }, 
                                TaskCreationOptions.AttachedToParent
                            );
                    }
                );

            t.Wait();
            Console.WriteLine("Main task completed");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -");
        }
    }
}
