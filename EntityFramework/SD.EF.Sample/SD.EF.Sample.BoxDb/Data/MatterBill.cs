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
    
    public partial class MatterBill
    {
        public int Id { get; set; }
        public int MatterId { get; set; }
        public int BillFrequencyId { get; set; }
        public int BillRateId { get; set; }
        public Nullable<int> BillRangeId { get; set; }
        public int AttorneyId { get; set; }
        public bool HasEngagementLetter { get; set; }
        public bool HasRetainer { get; set; }
        public bool IsBillable { get; set; }
        public string BillComment { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public int BillAttorneyId { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public Nullable<System.DateTime> WipDate { get; set; }
        public string RetainerAmount { get; set; }
        public Nullable<int> CreditLimit { get; set; }
        public string ClientMatterBill { get; set; }
        public string BillingName { get; set; }
        public string BillingCode { get; set; }
        public int CurrencyId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public int CreatedById { get; set; }
        public Nullable<System.DateTime> UpdatedOn { get; set; }
        public Nullable<int> UpdatedById { get; set; }
    
        public virtual BillFrequency BillFrequency { get; set; }
        public virtual BillRange BillRange { get; set; }
        public virtual BillRate BillRate { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Matter Matter { get; set; }
    }
}