// <copyright file="Lesson01.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>10/20/2014 7:34:40 PM</date>
// <summary></summary>
namespace SafeHandle.Lessons
{
    using CLR.Common.Contracts;
    using SafeHandle.DomainModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
	
	/// <summary>
	/// Lesson illustrate the simplest way to work with Dispose vs Finalize constructions.
	/// </summary>
    public class Lesson01 : ICommand
    {
        public void Execute()
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
        }
    }
}
