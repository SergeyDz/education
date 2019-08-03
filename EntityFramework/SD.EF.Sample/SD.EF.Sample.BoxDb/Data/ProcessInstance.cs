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
    
    public partial class ProcessInstance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProcessInstance()
        {
            this.ActivityInstance = new HashSet<ActivityInstance>();
            this.ProcessInstance1 = new HashSet<ProcessInstance>();
        }
    
        public int Id { get; set; }
        public int IsDeleted { get; set; }
        public int CreatedById { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedById { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public int ProcessId { get; set; }
        public int StatusId { get; set; }
        public int DocumentInstanceId { get; set; }
        public Nullable<int> ResultId { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<System.Guid> WorkflowInstanceGUID { get; set; }
    
        public virtual DocumentInstance DocumentInstance { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityInstance> ActivityInstance { get; set; }
        public virtual Process Process { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessInstance> ProcessInstance1 { get; set; }
        public virtual ProcessInstance ProcessInstance2 { get; set; }
        public virtual ProcessInstanceStatus ProcessInstanceStatus { get; set; }
    }
}