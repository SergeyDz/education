// <copyright file="Program.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>8/11/2014 8:23:54 PM</date>
// <summary></summary>
namespace Expression
{
    using Expression.DomainModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;

    partial class Program
    {
        static private void Run()
        {
            Initialize();

            //ShowAll();
            ShowWithDefinedId();

        }

        private static void ShowWithDefinedId()
        {
            //var x = list.Where(p=>Id = 5);
            var type = typeof(Client);
            var parameter = Expression.Parameter(type, "p");
            var propertyReference = Expression.Property(parameter, "Id");
            var constantReference = Expression.Constant(16);

            var expression = Expression.Lambda<Func<Client, bool>>(Expression.Equal(propertyReference, constantReference), new[] { parameter }).Compile();
            var results = list.Where(expression).ToList();
            results.ForEach(x => Console.WriteLine(x));
        }

        private static void ShowAll()
        {
            list.ForEach(x => Console.WriteLine(x));
        }
    }
}
