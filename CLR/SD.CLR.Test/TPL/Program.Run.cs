// <copyright file="Program.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>8/7/2014 3:04:27 PM</date>
// <summary></summary>
namespace TPL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    partial class Program
    {

        private static async Task RunTaskParallelInvoke()
        {
            Console.WriteLine("RunTaskParallelInvoke -> Parallel.Invoke(()=>Function1(), ()=>Function2());");

            Parallel.Invoke(()=>Function1(), ()=>Function2());

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -");
        }

        private static async Task RunTaskStartSimple()
        {
            Console.WriteLine("RunTaskStartSimple -> Task t1 = new Task(() => Function1());");

            Task t1 = new Task(() => Function1());
            t1.Start();
            Task t2 = new Task(() => Function2());
            t2.Start();

            //without this wait function continue execution till next await started
            await Task.WhenAll(t1, t2);

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -");
        }

        private static async Task RunTaskWhenAll()
        {
            Console.WriteLine("RunTaskWhenAll ->  Task t1 = Task.Run(() => Function1()); await Task.WhenAll(t2, t1);");
            Task t1 = Task.Run(() => Function1());
            Task t2 = Task.Run(() => Function2());

            await Task.WhenAll(t2, t1);

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -");
        }

        private static async Task RunTaskFunctionAssignment()
        {
            Console.WriteLine("RunTaskFunctionAssignment -> Task t1 = Function3(); await Task.WhenAll(t2, t1);");
            Task t1 = Function3();
            Task t2 = Function3();

            await Task.WhenAll(t2, t1);

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -");
        }

        private static async Task RunTaskAwait()
        {
            Console.WriteLine("RunTaskAwait -> long time1 = await Function1();");

            var t1 = Task<long>.Factory.StartNew(() => Function4());
            var t2 = Task.Factory.StartNew(() => Function3());
            Function3();

            Console.WriteLine("Time 1={0}, Time 2={1}", t1.Result, t2.Result);

            await Task.WhenAll(t1, t2);

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -");
        }
    }
}
