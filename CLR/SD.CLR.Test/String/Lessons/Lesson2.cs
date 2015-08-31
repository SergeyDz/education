// <copyright file="Lesson1.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>8/19/2014 11:20:37 AM</date>
// <summary></summary>
namespace String.Lessons
{
    using CLR.Common.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Lesson2 : ICommand
    {
        public void Execute()
        {
            Stopwatch timer = new Stopwatch();

            var f = File.ReadAllText("String.pdb", Encoding.ASCII);

            string a = f;
            string b = f.ToUpper();
            int N = 100000;

            //to try 
            timer.Start();

            for (int i = 0; i < N; i++)
            {
              
                bool c = a == b;
            }

            timer.Stop();
            timer.Reset();
            //try ended

            timer.Start();

            for (int i = 0; i < N; i++)
            {
              
                bool c = a == b;
            }

            timer.Stop();

            Console.WriteLine("a == b : {0}", timer.ElapsedTicks);
            timer.Reset();

            timer.Start();

            for (int i = 0; i < N; i++)
            {
               
                bool c = a.Equals(b);
            }

            timer.Stop();

            Console.WriteLine("a.Equals(b) : {0}", timer.ElapsedTicks);
            timer.Reset();

            timer.Start();

            for (int i = 0; i < N; i++)
            {
              
                bool c = a.CompareTo(b) == 0;
            }

            timer.Stop();

            Console.WriteLine("a.CompareTo(b) == 0 : {0}", timer.ElapsedTicks);
            timer.Reset();


            timer.Start();

            for (int i = 0; i < N; i++)
            {
               

                bool c = String.Compare(a, b) == 0;
            }

            timer.Stop();

            Console.WriteLine("String.Compare(a, b) == 0 : {0}", timer.ElapsedTicks);
            timer.Reset();
        }
    }
}
