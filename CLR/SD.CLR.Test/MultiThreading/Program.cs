using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MultiThreading.Lessons;
using CLR.Common.Contracts;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Initialize();

            ICommand command = new Lesson04();
            command.Execute();

            Complete();
        }

        private static void Complete()
        {
            Console.WriteLine("{0} Main thread completed.", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }

        private static void Initialize()
        {
            Console.WriteLine("{0} Main thread started. Context ID: {1}",
                Thread.CurrentThread.ManagedThreadId, Thread.CurrentContext.ContextID);
            Thread.CurrentThread.Name = "Main";
        }
    }
}
