using CLR.Common.Contracts;
using SafeHandle.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeHandle
{
    class Program
    {
        static void Main(string[] args)
        {
            ICommand command = new Lessons.Lesson02();
            command.Execute();
            Console.ReadKey();
        }
    }
}
