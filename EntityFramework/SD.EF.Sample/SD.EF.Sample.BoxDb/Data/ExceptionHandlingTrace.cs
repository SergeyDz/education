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
    
    public partial class ExceptionHandlingTrace
    {
        public int Id { get; set; }
        public int IsDeleted { get; set; }
        public int CreatedById { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedById { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public System.DateTime Date { get; set; }
        public string Exception { get; set; }
        public string Message { get; set; }
        public string Type { get; set; }
        public string RuleName { get; set; }
        public string RulePattern { get; set; }
        public string RequestContext { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
