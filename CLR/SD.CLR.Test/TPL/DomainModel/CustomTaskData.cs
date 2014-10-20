// <copyright file="CustomTaskData.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>8/8/2014 10:37:55 AM</date>
// <summary></summary>
namespace TPL.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [Serializable]
    public class CustomTaskData
    {
        public int ThreadId { set; get; }
        public int TaskId { set; get; }
        public int Index { set; get; }
    }
}
