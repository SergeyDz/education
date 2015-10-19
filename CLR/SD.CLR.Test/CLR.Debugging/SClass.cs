using System;

namespace CLR.Debugging
{
    public struct SClass
    {
        static SClass()
        {
            Console.WriteLine("SClass.StaticCtor");
        }

        public int Field1;
        public int Field2;

        public void Do()
        {
            Console.WriteLine("SClass.Do");

            if (Created != null)
            {
                Created(this, new EventArgs());
            }
        }

        public int Property { get; set; }

        public event EventHandler<EventArgs> Created;

    }
}
