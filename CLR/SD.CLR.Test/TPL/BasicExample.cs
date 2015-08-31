// <copyright file="BasicExample.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>8/14/2014 11:45:53 AM</date>
// <summary></summary>
namespace TPL
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BasicExample
    {
        public async Task Run()
        {
            await Run2();
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Run(i = {0})", i);
            }
        }

        public async Task Run2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Run2(i = {0})", i);
            }
        }
    }
}
