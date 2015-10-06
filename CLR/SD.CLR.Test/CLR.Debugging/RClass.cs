using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLR.Debugging
{
    public class RClass
    {
        public int field1; 

        public int Property { get; set; }

        public void Do()
        {
            Console.WriteLine("RClass.Do()");
        }
      
    }
}
