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
    
    public partial class Person1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person1()
        {
            this.Request1 = new HashSet<Request1>();
        }
    
        public int Id { get; set; }
        public Nullable<int> OfficeId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public string Email { get; set; }
        public Nullable<int> ExternalId { get; set; }
        public string TimeKeeperCode { get; set; }
        public string PersonnelType { get; set; }
        public string PersonnelTypeCode { get; set; }
        public string PhoneNum { get; set; }
    
        public virtual Person Person { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request1> Request1 { get; set; }
    }
}
