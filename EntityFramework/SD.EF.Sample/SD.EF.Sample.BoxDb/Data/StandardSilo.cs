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
    
    public partial class StandardSilo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StandardSilo()
        {
            this.HoldSilo = new HashSet<HoldSilo>();
            this.SiloOrgUnit = new HashSet<SiloOrgUnit>();
            this.StandardSiloCustodian = new HashSet<StandardSiloCustodian>();
            this.StandardSiloDataSteward = new HashSet<StandardSiloDataSteward>();
            this.StandardSiloQuestion = new HashSet<StandardSiloQuestion>();
        }
    
        public int Id { get; set; }
        public int IsDeleted { get; set; }
        public int CreatedById { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedById { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string Image { get; set; }
        public int SiloTypeId { get; set; }
        public int Weight { get; set; }
        public Nullable<int> CollectionTimeValue { get; set; }
        public Nullable<int> CollectionTimeUnitId { get; set; }
        public string Location { get; set; }
        public Nullable<int> ResponsibleCustodianId { get; set; }
        public Nullable<System.DateTime> CutOffDate { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual CollectionTimeUnit CollectionTimeUnit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoldSilo> HoldSilo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SiloOrgUnit> SiloOrgUnit { get; set; }
        public virtual SiloType SiloType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StandardSiloCustodian> StandardSiloCustodian { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StandardSiloDataSteward> StandardSiloDataSteward { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StandardSiloQuestion> StandardSiloQuestion { get; set; }
    }
}
