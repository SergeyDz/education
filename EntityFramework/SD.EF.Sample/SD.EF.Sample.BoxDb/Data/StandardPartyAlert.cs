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
    
    public partial class StandardPartyAlert
    {
        public int Id { get; set; }
        public int StandardPartyId { get; set; }
        public int StandardPartyAlertTypeId { get; set; }
        public string Comment { get; set; }
        public bool IsFormer { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedById { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> UpdatedById { get; set; }
    
        public virtual StandardPartyAlertType StandardPartyAlertType { get; set; }
        public virtual StandardParty StandardParty { get; set; }
    }
}
