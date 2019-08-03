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
    
    public partial class KYCVClient
    {
        public int Id { get; set; }
        public Nullable<bool> IsFinancialPublicIssuer { get; set; }
        public Nullable<bool> IsFundsPaid { get; set; }
        public Nullable<bool> IsFundsWithinExemptions { get; set; }
        public Nullable<bool> IsFromFinancialInstitution { get; set; }
        public Nullable<bool> IsFromPublicBody { get; set; }
        public Nullable<bool> IsFromReportingIssuer { get; set; }
        public Nullable<bool> IsFromTrustAccount { get; set; }
        public Nullable<bool> IsFromOfficer { get; set; }
        public Nullable<bool> IsFromPursuantCourtOrder { get; set; }
        public Nullable<bool> IsFromSettlement { get; set; }
        public Nullable<bool> IsFromProfessionalFees { get; set; }
        public Nullable<bool> IsToFinancialInstitution { get; set; }
        public Nullable<bool> IsToPublicBody { get; set; }
        public Nullable<bool> IsToReportingIssuer { get; set; }
        public Nullable<bool> IsFinePayment { get; set; }
        public Nullable<bool> IsToPursuantCourtOrder { get; set; }
        public Nullable<bool> IsToSettlement { get; set; }
        public Nullable<bool> IsToProfessionalFees { get; set; }
        public Nullable<int> OriginalDocReviewedId { get; set; }
        public string AnnualFillingType { get; set; }
        public string OriginalDocNote { get; set; }
        public Nullable<bool> IsKYCVDirectorChanged { get; set; }
        public Nullable<bool> IsKYCVShareholderChanged { get; set; }
        public string AuthorizedPersonContactCode { get; set; }
        public Nullable<int> OriginalPersonDocReviewedId { get; set; }
        public string DocNumPersonVerification { get; set; }
        public string Notes { get; set; }
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
        public Nullable<bool> IsVerifiedByDocId { get; set; }
        public string NotesIND { get; set; }
        public Nullable<int> VerifiedById { get; set; }
        public Nullable<System.DateTime> VerifiedOn { get; set; }
        public string ClintName { get; set; }
        public string ClintCode { get; set; }
        public string MatterName { get; set; }
        public string MatterCode { get; set; }
        public Nullable<int> BillingLawyerId { get; set; }
        public Nullable<int> ResponsibleLawyerId { get; set; }
        public Nullable<bool> IsPartyClient { get; set; }
        public int RequestId { get; set; }
    }
}