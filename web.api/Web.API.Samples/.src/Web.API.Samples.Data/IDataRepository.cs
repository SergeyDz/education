// <copyright file="IDataRepository.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>7/11/2014 3:06:43 PM</date>
// <summary>Contract for DB repository</summary>
namespace Web.API.Samples.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IDataRepository
    {
        T GetByKey<T>(string key);

        void Save<T>(T entity);

        IEnumerable<T> GetAll<T>();
    }
}
