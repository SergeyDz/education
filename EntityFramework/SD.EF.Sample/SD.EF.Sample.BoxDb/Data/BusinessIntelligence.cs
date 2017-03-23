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
    
    public partial class BusinessIntelligence
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int BusinessIntelligenceTypeId { get; set; }
        public Nullable<int> ClientJurisdictionId { get; set; }
        public Nullable<int> MatterJurisdictionId { get; set; }
        public Nullable<int> ClientIndustryId { get; set; }
        public Nullable<int> MatterIndustryId { get; set; }
        public Nullable<int> LegalTopicId { get; set; }
        public int IsDeleted { get; set; }
    
        public virtual Industry Industry { get; set; }
        public virtual Industry Industry1 { get; set; }
        public virtual Request Request { get; set; }
        public virtual BusinessIntelligenceType BusinessIntelligenceType { get; set; }
        public virtual LegalTopic LegalTopic { get; set; }
    }
}
