//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SD.EF.Sample.BoxDb.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaskList
    {
        public int ActivityInstanceId { get; set; }
        public int ActivityId { get; set; }
        public int ProcessInstanceId { get; set; }
        public string ActivityInstanceName { get; set; }
        public string ActivityName { get; set; }
        public int RequestId { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int MatterId { get; set; }
        public string MatterName { get; set; }
        public int CreatedById { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedById { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string RequestTypeCode { get; set; }
        public string RequestTypeName { get; set; }
        public int UserId { get; set; }
        public string StatusCode { get; set; }
        public Nullable<int> ParentId { get; set; }
    }
}
