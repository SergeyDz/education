// <copyright file="FileWriter.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>10/20/2014 8:08:11 PM</date>
// <summary></summary>
namespace SafeHandle.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FileWriter
    {
        protected FileStream stream;
        HandleCollector collector;

        public FileWriter(string path, HandleCollector hCollector)
        {
            stream = new FileStream(path, FileMode.OpenOrCreate);
            collector = hCollector;
            collector.Add();
            Console.WriteLine("FileWriter created for path: " + path);
        }

        ~FileWriter()
        {
            Console.WriteLine("Finalizer called...");
            collector.Remove();
        }
    }
}
