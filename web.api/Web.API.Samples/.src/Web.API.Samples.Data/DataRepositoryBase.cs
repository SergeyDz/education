// <copyright file="DataRepositoryBase.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>7/13/2014 10:40:27 PM</date>
// <summary></summary>
namespace Web.API.Samples.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Base class for data repository implementation
    /// </summary>
    public abstract class DataRepositoryBase : IDataRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataRepositoryBase"/> class.
        /// </summary>
        public DataRepositoryBase()
        {
            Lock = new ReaderWriterLockSlim(LockRecursionPolicy.SupportsRecursion);
        }

        /// <summary>
        /// Gets Locker object with read\write operations support to avoid concurrency issues. 
        /// </summary>
        protected ReaderWriterLockSlim Lock { get; private set; }

        #region IDataRepository declaration

        public abstract T GetByKey<T>(string key);

        public abstract void Save<T>(T entity);

        public abstract IEnumerable<T> GetAll<T>();

        #endregion 
    }
}
