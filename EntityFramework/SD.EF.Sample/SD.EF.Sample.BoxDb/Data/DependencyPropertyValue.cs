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
    
    public partial class DependencyPropertyValue
    {
        public int Id { get; set; }
        public int IsDeleted { get; set; }
        public int CreatedById { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public Nullable<int> UpdatedById { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public int DependencyId { get; set; }
        public int DependencyPropertyId { get; set; }
        public string Value { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual Dependency Dependency { get; set; }
        public virtual DependencyProperty DependencyProperty { get; set; }
    }
}