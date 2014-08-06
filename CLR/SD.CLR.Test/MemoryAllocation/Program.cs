using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MemoryAllocation
{
    class Program
    {
        public static unsafe void Main(string[] args)
        {
            int i;
            string a = "", b = "", c = "";

            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();


            string d = b + c;
            int* ptr = &i;
            IntPtr addr = (IntPtr)ptr;

            Console.WriteLine(addr.ToString("x"));

            GCHandle h = GCHandle.Alloc(a, GCHandleType.Pinned);
            addr = h.AddrOfPinnedObject();
            Console.WriteLine("A = " + a + " *A = " + addr.ToString("x"));

            h = GCHandle.Alloc(b, GCHandleType.Pinned);
            addr = h.AddrOfPinnedObject();
            Console.WriteLine("B = " + b + " *B = " + addr.ToString("x"));

            h = GCHandle.Alloc(c, GCHandleType.Pinned);
            addr = h.AddrOfPinnedObject();
            Console.WriteLine("C = " + c + " *C = " + addr.ToString("x"));

            h = GCHandle.Alloc(d, GCHandleType.Pinned);
            addr = h.AddrOfPinnedObject();
            Console.WriteLine("D = " + d + " *D = " + addr.ToString("x"));

            h.Free();

            Console.ReadKey();
        }
    }
}
