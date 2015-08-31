using CLR.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            ICommand command = new Lessons.Lesson1();
            command.Execute();

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
