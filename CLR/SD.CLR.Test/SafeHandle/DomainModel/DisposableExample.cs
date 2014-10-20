// <copyright file="DisposableExample.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>10/20/2014 3:29:14 PM</date>
// <summary></summary>
namespace SafeHandle.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DisposableExample : IDisposable
    {
        private FileStream stream;
        private readonly string path;
        private bool disposed;

        public DisposableExample(string filePath)
        {
            path = filePath;
            stream = new FileStream(path, FileMode.OpenOrCreate);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                stream.Dispose();

                if (disposing)
                {
                    Console.WriteLine("Disposing " + path);
                    disposed = true;
                }
                else
                {
                    Console.WriteLine("Finalizing " + path);
                    stream = null;
                }
            }
        }

        ~DisposableExample()
        {
            Dispose(false);
        }

    }
}
