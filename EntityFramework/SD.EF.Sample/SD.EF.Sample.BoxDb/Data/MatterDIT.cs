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
    
    public partial class MatterDIT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MatterDIT()
        {
            this.DITEmail = new HashSet<DITEmail>();
        }
    
        public int Id { get; set; }
        public int MatterId { get; set; }
        public int UserIdAttorney { get; set; }
        public string DitTypeId { get; set; }
        public Nullable<System.DateTime> EventDate { get; set; }
        public int FollowUpFreq { get; set; }
        public int FollowUpPastCount { get; set; }
        public Nullable<System.DateTime> ReceiveDate { get; set; }
        public string ReceiveNote { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> SentDate { get; set; }
        public string DitActionId { get; set; }
        public string StatusMsg { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedById { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> UpdatedById { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DITEmail> DITEmail { get; set; }
        public virtual Matter Matter { get; set; }
    }
}
