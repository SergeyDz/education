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
            for (int i = 0; i < 10; i++)
            {
                using (var example = new DisposableExample("disposed." + i + ".txt"))
                {
                    Console.WriteLine("Run some code for i=" + i);
                }
              
                var example2 = new DisposableExample("undisposed." + i + ".txt");
            }

            Console.WriteLine("GC collecting...");
            GC.Collect();

            Console.ReadKey();
        }
    }
}
