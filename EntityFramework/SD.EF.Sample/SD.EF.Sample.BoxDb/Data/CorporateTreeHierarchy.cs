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
    
    public partial class CorporateTreeHierarchy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CorporateTreeHierarchy()
        {
            this.CorporateTreeHierarchy1 = new HashSet<CorporateTreeHierarchy>();
            this.CorporateTreeHierarchy11 = new HashSet<CorporateTreeHierarchy>();
        }
    
        public int Id { get; set; }
        public int StandardPartyId { get; set; }
        public string Hierarchy { get; set; }
        public string ParentHierarchy { get; set; }
        public short Level { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<int> ParentTopId { get; set; }
        public int NodeChildrenCount { get; set; }
        public int CorpTreeId { get; set; }
        public string Notes { get; set; }
        public Nullable<int> PartyRelId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedById { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> UpdatedById { get; set; }
    
        public virtual PartyRelation PartyRelation { get; set; }
        public virtual CorporateTree CorporateTree { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CorporateTreeHierarchy> CorporateTreeHierarchy1 { get; set; }
        public virtual CorporateTreeHierarchy CorporateTreeHierarchy2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CorporateTreeHierarchy> CorporateTreeHierarchy11 { get; set; }
        public virtual CorporateTreeHierarchy CorporateTreeHierarchy3 { get; set; }
        public virtual StandardParty StandardParty { get; set; }
    }
}
