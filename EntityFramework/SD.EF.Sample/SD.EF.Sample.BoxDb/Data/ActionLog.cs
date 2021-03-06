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
    
    public partial class ActionLog
    {
        public int Id { get; set; }
        public int IsDeleted { get; set; }
        public int CreatedById { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedById { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string Data { get; set; }
        public string OldData { get; set; }
        public Nullable<int> ActivityInstanceId { get; set; }
        public Nullable<int> DocumentInstanceId { get; set; }
    
        public virtual DocumentInstance DocumentInstance { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ActivityInstance ActivityInstance { get; set; }
    }
}
