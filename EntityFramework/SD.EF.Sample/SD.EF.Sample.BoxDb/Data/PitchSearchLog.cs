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
    
    public partial class PitchSearchLog
    {
        public int PitchId { get; set; }
        public int SearchId { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedById { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string UpdatedById { get; set; }
        public string Reserved1 { get; set; }
        public string Reserved2 { get; set; }
        public Nullable<System.DateTime> Reserved3 { get; set; }
        public Nullable<int> Reserved4 { get; set; }
    
        public virtual Pitch Pitch { get; set; }
    }
}
