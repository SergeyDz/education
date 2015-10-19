using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLR.Debugging
{
    public class Program
    {
        static void Main(string[] args)
        {
            RClass r = new RClass();
            r.field1 = 1;
            r.Property = 2;
            r.Do();

            SClass struc = new SClass();
            struc.Created += (t, a) => { Console.WriteLine("OnCreated delegate 1"); };
            struc.Created += (t, a) => { Console.WriteLine("OnCreated delegate 2"); };
            struc.Do();

            Console.ReadKey();
        }
    }
}
