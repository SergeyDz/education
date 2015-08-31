// <copyright file="Lesson1.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>8/20/2014 10:20:50 AM</date>
// <summary></summary>
namespace AppDomain.Lessons
{
    using CLR.Common.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using AppDomain.Common;

    public class Lesson1 : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Current domain name: {0}", AppDomain.CurrentDomain.FriendlyName);

            var setup = new AppDomainSetup()
            {
                ShadowCopyFiles = "true"
            };
            AppDomain child = AppDomain.CreateDomain("child", AppDomain.CurrentDomain.Evidence, setup);
            
            var current = Thread.GetDomain();


            child.LoadAssemblyRelativePath(@"..\..\..\CLR.Common.Contracts\bin\Debug\CLR.Common.Contracts.dll");
            //child.LoadAssemblyRelativePath(@"..\..\..\MultiThreading\bin\Debug\MultiThreading.exe");

            var obj = child.CreateInstanceFrom(@"..\..\..\CLR.Common.Contracts\bin\Debug\CLR.Common.Contracts.dll",
                "CLR.Common.Contracts.TestClass");
            var actor = obj.Unwrap();

            Type t = actor.GetType();
            MethodInfo mi = t.GetMethod("Probe");

            mi.Invoke(actor, null);

            AppDomain.Unload(child);
        }
    }
}
