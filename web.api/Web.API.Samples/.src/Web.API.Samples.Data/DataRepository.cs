// <copyright file="DataRepository.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>7/13/2014 10:59:32 PM</date>
// <summary></summary>
namespace Web.API.Samples.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Objects;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DataRepository : DataRepositoryBase
    {
        private readonly ObjectContext context;

        public DataRepository(ObjectContext objectContext)
        {
            context = objectContext;
        }

        public override T GetByKey<T>(string key)
        {
            throw new NotImplementedException();
        }

        public override void Save<T>(T entity)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<T> GetAll<T>()
        {
            throw new NotImplementedException();
        }
    }
}
