// <copyright file="Lesson02.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>10/20/2014 8:07:22 PM</date>
// <summary></summary>
namespace SafeHandle.Lessons
{
    using CLR.Common.Contracts;
    using SafeHandle.DomainModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;

    public class Lesson02 : ICommand
    {
        public void Execute()
        {
            HandleCollector collector = new HandleCollector("Hello world collector", 4, 8);
            for (int i = 0; i < 20; i++)
            {
                FileWriter writer = new FileWriter("Lesson02 - " + i + ".txt", collector);
            }

            Console.ReadKey();
        }
    }

}
