// <copyright file="Client.cs" company="localhost">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author>Sergey Dzyuban</author>
// <date>8/11/2014 8:26:33 PM</date>
// <summary></summary>
namespace Expression.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Notes { get; set; }

        public override string ToString()
        {
            return string.Format("Id = {0}, Name = {1}, Status = {2}, CreatedOn = {3}", Id, Name, Status, CreatedOn);
        }
    }
}
