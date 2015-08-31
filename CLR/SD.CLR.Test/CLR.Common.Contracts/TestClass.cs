// <copyright file="TestClass.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>8/20/2014 11:31:50 AM</date>
// <summary></summary>
namespace CLR.Common.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Serializable]
    public class TestClass : MarshalByRefObject
    {
        public void Probe()
        {
            Console.WriteLine("Hello world from {0}", AppDomain.CurrentDomain.FriendlyName);
        }
    }
}
