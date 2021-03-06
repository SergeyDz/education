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
    
    public partial class SearchRequest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SearchRequest()
        {
            this.EntityScoreByDateSource = new HashSet<EntityScoreByDateSource>();
            this.SearchRequestAttachment = new HashSet<SearchRequestAttachment>();
            this.SearchRequestDataSource = new HashSet<SearchRequestDataSource>();
            this.SearchRequestTerm = new HashSet<SearchRequestTerm>();
            this.SearchResult_COI = new HashSet<SearchResult_COI>();
        }
    
        public int Id { get; set; }
        public int ClientMatterId { get; set; }
        public int UserIdPerformSearch { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string SrTitle { get; set; }
        public string SrNote { get; set; }
        public string SrRe { get; set; }
        public string SrRefNo { get; set; }
        public string PerformedBy { get; set; }
        public int OfficeId { get; set; }
        public string CoiReportTypeId { get; set; }
        public string SrSource { get; set; }
        public bool IsNotSearchable { get; set; }
        public bool HasAttachment { get; set; }
        public string FlagStatus { get; set; }
        public string FlagSearchStatus { get; set; }
        public Nullable<System.DateTime> SearchDate { get; set; }
        public Nullable<int> ParentSearchRequestId { get; set; }
        public int SourceSearchRequestId { get; set; }
        public int ChildrenCount { get; set; }
        public string SrComment { get; set; }
        public Nullable<System.DateTime> ExpirationDate { get; set; }
        public Nullable<System.DateTime> DispositionDate { get; set; }
        public int UserIdAttorney { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedById { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> UpdatedById { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntityScoreByDateSource> EntityScoreByDateSource { get; set; }
        public virtual Matter Matter { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SearchRequestAttachment> SearchRequestAttachment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SearchRequestDataSource> SearchRequestDataSource { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SearchRequestTerm> SearchRequestTerm { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SearchResult_COI> SearchResult_COI { get; set; }
    }
}
