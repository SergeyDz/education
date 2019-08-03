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
    
    public partial class Dependency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dependency()
        {
            this.DependencyPropertyValue = new HashSet<DependencyPropertyValue>();
        }
    
        public int Id { get; set; }
        public int IsDeleted { get; set; }
        public int CreatedById { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedById { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public int SourceElementId { get; set; }
        public int TargetElementId { get; set; }
        public int DependencyActionId { get; set; }
        public string Condition { get; set; }
        public string IsActive { get; set; }
        public string Notes { get; set; }
        public string CheckActive { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual DependencyAction DependencyAction { get; set; }
        public virtual Element Element { get; set; }
        public virtual Element Element1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DependencyPropertyValue> DependencyPropertyValue { get; set; }
    }
}