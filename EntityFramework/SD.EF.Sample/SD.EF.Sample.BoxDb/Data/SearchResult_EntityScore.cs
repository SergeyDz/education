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
    
    public partial class SearchResult_EntityScore
    {
        public int Id { get; set; }
        public int SearchRequestId { get; set; }
        public int TechScore { get; set; }
        public int BusScore { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedById { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> UpdatedById { get; set; }
    }
}
