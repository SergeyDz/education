// <copyright file="FileReaded.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>10/20/2014 3:03:34 PM</date>
// <summary></summary>
namespace SafeHandle.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FileReaded : System.Runtime.InteropServices.SafeHandle
    {
        public FileReaded(System.IntPtr invalidHandleValue)
            : base(invalidHandleValue, true)
        { }

        public override bool IsInvalid
        {
            get { throw new NotImplementedException(); }
        }

        protected override bool ReleaseHandle()
        {
            throw new NotImplementedException();
        }
    }
}
