// <copyright file="TestClass.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>8/14/2014 10:59:03 AM</date>
// <summary></summary>
namespace Expression.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestClass
    {
        delegate string TestDelegate(string x);

        public void Run001()
        {
            List<string> a = new List<string>();
            var b = a.Where(p=>p == "xxx");
        }

        public void Run002()
        {
            TestDelegate a = Funct1;
            var b = a("hello world");
        }

        public string Funct1(string x)
        {
            return x.Substring(0, x.Length - 2);
        }
    }
}
