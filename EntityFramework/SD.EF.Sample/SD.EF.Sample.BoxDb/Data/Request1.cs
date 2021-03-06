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
    
    public partial class Request1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Request1()
        {
            this.Comment = new HashSet<Comment>();
            this.RequestUser1 = new HashSet<RequestUser1>();
        }
    
        public int Id { get; set; }
        public Nullable<int> ResponsibleLawyerId { get; set; }
        public Nullable<int> BillingLawyerId { get; set; }
        public Nullable<bool> IsAnyIndividuals { get; set; }
        public Nullable<bool> IsProBono { get; set; }
        public Nullable<bool> IsSameAsClient { get; set; }
        public Nullable<bool> IsSendRetainerLetter { get; set; }
        public Nullable<bool> IsSameAsResponsibleLawyer { get; set; }
        public Nullable<System.DateTime> PrescriptionDate { get; set; }
        public Nullable<int> MarketingActivityId { get; set; }
        public Nullable<int> PracticeId { get; set; }
        public Nullable<int> PrimarySourceOfWorkId { get; set; }
        public Nullable<int> PrimaryReferrerNameId { get; set; }
        public Nullable<int> SecondarySourceOfWorkId { get; set; }
        public Nullable<int> SecondaryReferrerNameId { get; set; }
        public string GeneralNote { get; set; }
        public Nullable<bool> IsLinkNeeded { get; set; }
        public Nullable<bool> HasAdditionalMatters { get; set; }
        public Nullable<bool> HasAdditionalMatterDescription { get; set; }
        public Nullable<bool> HasAdditionalRelatedEntities { get; set; }
        public Nullable<bool> HasAdditionalRestrictedList { get; set; }
        public Nullable<bool> HasAdditionalEmailAddress { get; set; }
        public Nullable<bool> HasAdditionalEbillingReferenceNo { get; set; }
        public Nullable<bool> HasClientReferenceNo { get; set; }
        public Nullable<bool> IsMainClient { get; set; }
        public Nullable<bool> IsPartyClient { get; set; }
        public Nullable<bool> IsEngagementLetter { get; set; }
        public string EngagementDescription { get; set; }
        public Nullable<bool> IsNewEngagementLetter { get; set; }
        public Nullable<int> NewEngagementLetterReasonId { get; set; }
        public Nullable<int> EngagementLetterTypeId { get; set; }
        public Nullable<int> EngagementLetterDeviationId { get; set; }
        public string NewEngagementLetterDescription { get; set; }
        public Nullable<bool> IsEngagementLetterAuthorized { get; set; }
        public Nullable<int> EngagementLetterApproverId { get; set; }
        public string EngagementLetterApproverComment { get; set; }
        public string EngagementLetterRequestorComment { get; set; }
        public Nullable<bool> IsEngagementLetterApproved { get; set; }
        public Nullable<bool> IsAttorneyRelationship { get; set; }
        public Nullable<int> AttorneyRelationshipId { get; set; }
        public Nullable<int> RelationshipLawyerId { get; set; }
        public string RelationshipLawyerName { get; set; }
        public string AttorneyRelationshipDescription { get; set; }
        public Nullable<bool> IsPriorDisputes { get; set; }
        public string PriorDisputesDescription { get; set; }
        public Nullable<bool> IsOtherAttroney { get; set; }
        public string ProformaReviewer { get; set; }
        public Nullable<bool> HasMarketingOpportunities { get; set; }
        public string MarketingOpportunitiesDescription { get; set; }
        public Nullable<bool> IsCourthouseNewsService { get; set; }
        public Nullable<int> ReferrerTypeId { get; set; }
        public Nullable<bool> HasDiversityCompliance { get; set; }
        public Nullable<bool> HasGreenCompliance { get; set; }
        public Nullable<int> DepartmentCounter { get; set; }
        public string ProbonoOtherMatters { get; set; }
        public string ProbonoActiveMatterDetails { get; set; }
        public string ProbonoRsponsbilityOther { get; set; }
        public string ProbonoTimeEstimate { get; set; }
        public string ProbonoStaffingNeeds { get; set; }
        public string ProbonoOutOfPocketCosts { get; set; }
        public string ProbonoFirmResourcesDescription { get; set; }
        public string ProbonoExplanation { get; set; }
        public string ProbonoPublicity { get; set; }
        public string ProbonoExpertise { get; set; }
        public Nullable<int> ProbonoResponsbilityId { get; set; }
        public Nullable<bool> IsProbonoFirmResources { get; set; }
        public Nullable<bool> ProbonoFirmResearch { get; set; }
        public Nullable<bool> HasActiveMatter { get; set; }
        public string BatchNumber { get; set; }
        public Nullable<int> MarketingTypeId { get; set; }
        public Nullable<int> OfficeId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<int> NonStandardEngagementLetterApproverId { get; set; }
        public Nullable<int> ArbitrationProvisionWaiverApproverId { get; set; }
        public Nullable<int> ApplicationGoverningLawApproverId { get; set; }
        public Nullable<int> NoRetainerApproverId { get; set; }
        public Nullable<int> MinimumLitigationRetainerApproverId { get; set; }
        public Nullable<int> SpecialFeeArrangementApproverId { get; set; }
        public Nullable<int> CostOverridesApproverId { get; set; }
        public Nullable<bool> IsNonStandardEngagementLetterApproved { get; set; }
        public Nullable<bool> IsArbitrationProvisionWaiverApproved { get; set; }
        public Nullable<bool> IsApplicationGoverningLawApproved { get; set; }
        public Nullable<bool> IsNoRetainerApproved { get; set; }
        public Nullable<bool> IsMinimumLitigationRetainerApproved { get; set; }
        public Nullable<bool> IsSpecialFeeArrangementApproved { get; set; }
        public Nullable<bool> IsCostOverridesApproved { get; set; }
        public Nullable<bool> IsArbitrationProvisionWaiver { get; set; }
        public Nullable<bool> IsArbitrationProvisionWaiverPreauthorized { get; set; }
        public Nullable<bool> IsApplicationGoverningLaw { get; set; }
        public Nullable<bool> IsApplicationGoverningLawPreauthorized { get; set; }
        public Nullable<bool> IsMininumLitRetainerPreauthorized { get; set; }
        public Nullable<bool> IsCostOverridePreauthorized { get; set; }
        public Nullable<int> EngagementLetterStatusId { get; set; }
        public Nullable<int> NonStandardEngagementLetterApproverPbId { get; set; }
        public Nullable<bool> IsNonStandardEngagementLetterApprovedPb { get; set; }
        public Nullable<bool> IsKYCDisabled { get; set; }
        public Nullable<int> AssignedLawyerId { get; set; }
        public Nullable<bool> IsSameAsBillingLawyer { get; set; }
        public Nullable<bool> IsEntityInvolved { get; set; }
        public string EntityInvolved { get; set; }
        public Nullable<bool> IsCompetitiveBid { get; set; }
        public string EntityInvolvedRestrictedMatter { get; set; }
        public Nullable<int> ClearConflictUserId { get; set; }
        public Nullable<System.DateTime> ClearConflictCreatedOn { get; set; }
        public Nullable<bool> HasLondonAmlConfirmation { get; set; }
        public string Exception { get; set; }
        public Nullable<int> KYCIInheritedRequestId { get; set; }
        public Nullable<int> KYCIPopulateRequestId { get; set; }
        public Nullable<int> KYCVInheritedRequestId { get; set; }
        public Nullable<int> KYCVPopulateRequestId { get; set; }
        public Nullable<bool> IsClearConflictExists { get; set; }
        public Nullable<bool> IsClearConflictAppproved { get; set; }
        public Nullable<bool> IsClearConflictDeclined { get; set; }
        public string ClientCode { get; set; }
        public Nullable<bool> IsKYCIPopulated { get; set; }
        public Nullable<bool> IsKYCVPopulated { get; set; }
        public Nullable<bool> IsRelyActivated { get; set; }
        public Nullable<bool> IsBEFActivated { get; set; }
        public string KYCStatus { get; set; }
        public Nullable<System.Guid> UniqueId { get; set; }
        public Nullable<bool> IsCompiledWithCompetitiveBid { get; set; }
        public Nullable<bool> IsAlternateFeeArrangement { get; set; }
        public string AlternateFeeArrangementNotes { get; set; }
    
        public virtual ReferralSource ReferralSource { get; set; }
        public virtual ReferralSource ReferralSource1 { get; set; }
        public virtual Department2 Department2 { get; set; }
        public virtual Office Office { get; set; }
        public virtual Practice Practice { get; set; }
        public virtual Request Request { get; set; }
        public virtual AttorneyRelationship AttorneyRelationship { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual EngagementLetterDeviation EngagementLetterDeviation { get; set; }
        public virtual EngagementLetterReason EngagementLetterReason { get; set; }
        public virtual EngagementLetterStatus EngagementLetterStatus { get; set; }
        public virtual EngagementLetterType EngagementLetterType { get; set; }
        public virtual MarketingActivity MarketingActivity { get; set; }
        public virtual MarketingType MarketingType { get; set; }
        public virtual Person1 Person1 { get; set; }
        public virtual Referrer Referrer { get; set; }
        public virtual Referrer Referrer1 { get; set; }
        public virtual ReferrerType ReferrerType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestUser1> RequestUser1 { get; set; }
        public virtual ResponsbilityType ResponsbilityType { get; set; }
    }
}
