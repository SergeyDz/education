// <copyright file="SampleClass.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>8/19/2014 10:59:55 AM</date>
// <summary></summary>
namespace String.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SampleClass
    {
        public string Content { get; set; }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
