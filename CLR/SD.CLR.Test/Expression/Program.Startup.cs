// <copyright file="Program.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>8/11/2014 8:25:47 PM</date>
// <summary></summary>
namespace Expression
{
    using Expression.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    static partial class Program
    {
        private static List<Client> list = new List<Client>();

        private static void Initialize()
        {
            for (int i = 0; i < 100; i++)
            {
                string guid = Guid.NewGuid().ToString();
                list.Add(new Client()
                    {
                        Name = guid.Substring(0, 8),
                        Id = i, 
                        Notes = guid,
                        Status = i % 2 == 0 ? "Open":"Closed",
                        CreatedOn = DateTime.Now
                    });
            }
        }
    }
}
