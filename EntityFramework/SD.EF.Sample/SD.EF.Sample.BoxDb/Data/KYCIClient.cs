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
    
    public partial class KYCIClient
    {
        public int Id { get; set; }
        public string Occupation { get; set; }
        public string BusinessContactAddress1 { get; set; }
        public string BusinessContactAddress2 { get; set; }
        public string BusinessContactAddress3 { get; set; }
        public string BusinessContactAddress4 { get; set; }
        public Nullable<int> BusinessContactCountryId { get; set; }
        public Nullable<int> BusinessContactStateId { get; set; }
        public string BusinessContactAddressNotes { get; set; }
        public string BusinessContactCity { get; set; }
        public string BusinessContactZip { get; set; }
        public string BusinessContactPhone { get; set; }
        public string HomeContactAddress1 { get; set; }
        public string HomeContactAddress2 { get; set; }
        public string HomeContactAddress3 { get; set; }
        public string HomeContactAddress4 { get; set; }
        public Nullable<int> HomeContactCountryId { get; set; }
        public Nullable<int> HomeContactStateId { get; set; }
        public string HomeContactAddressNotes { get; set; }
        public string HomeContactCity { get; set; }
        public string HomeContactZip { get; set; }
        public string HomeContactPhone { get; set; }
        public Nullable<bool> IsInvolve { get; set; }
        public string IdentificationNo { get; set; }
        public string PlaceOfIssue { get; set; }
        public string Notes { get; set; }
        public string AuthorizedPersonContactCode { get; set; }
        public Nullable<int> IdentifiedById { get; set; }
        public Nullable<System.DateTime> IdentifiedOn { get; set; }
        public string ClintName { get; set; }
        public string ClintCode { get; set; }
        public string KycClintName { get; set; }
        public string KycClintCode { get; set; }
        public string MatterName { get; set; }
        public string MatterCode { get; set; }
        public Nullable<int> BillingLawyerId { get; set; }
        public Nullable<int> ResponsibleLawyerId { get; set; }
        public Nullable<bool> IsPartyClient { get; set; }
        public int RequestId { get; set; }
    }
}