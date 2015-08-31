using CLR.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ICommand command = new Lessons.Lesson2();
            command.Execute();

            Console.WriteLine(GC.GetGeneration(command));

            Console.ReadKey();
        }
    }
}
