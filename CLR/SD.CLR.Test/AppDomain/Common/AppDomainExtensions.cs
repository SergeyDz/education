// <copyright file="AppDomainExtensions.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>8/20/2014 11:16:55 AM</date>
// <summary></summary>
namespace AppDomain.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;

    public static class AppDomainExtensions
    {
        public static void LoadAssemblyRelativePath(this AppDomain child, string path)
        {
            child.AssemblyLoad += child_AssemblyLoad;

            var basePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
            var assemblyName = AssemblyName.GetAssemblyName(basePath);
            child.Load(assemblyName); 
        }

        static void child_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
        {
            Console.WriteLine(args.LoadedAssembly.FullName);
        }
    }
}
