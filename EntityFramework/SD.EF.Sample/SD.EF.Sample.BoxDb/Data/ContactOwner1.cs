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
    
    public partial class ContactOwner1
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public int ContactOwnerTypeId { get; set; }
        public Nullable<int> RequestId { get; set; }
        public Nullable<int> PartyId { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<int> MatterId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedById { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> UpdatedById { get; set; }
    
        public virtual ContactOwnerType ContactOwnerType { get; set; }
        public virtual Client1 Client1 { get; set; }
        public virtual Contact1 Contact1 { get; set; }
        public virtual Matter1 Matter1 { get; set; }
        public virtual Party Party { get; set; }
        public virtual Request Request { get; set; }
    }
}
