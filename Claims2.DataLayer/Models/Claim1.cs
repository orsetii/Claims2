using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Claim1
    {
        public Claim1()
        {
            ClaimItem2s = new HashSet<ClaimItem2>();
            TriageOutcomes = new HashSet<TriageOutcome>();
        }

        public int ClaimId { get; set; }
        public string? PolicyNumber { get; set; }
        public string? PostCode { get; set; }
        public int AccountId { get; set; }
        public DateTime DateCreated { get; set; }
        public int? LeadItemId { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public int? TitleId { get; set; }
        public string? InsuredCompanyName { get; set; }
        public string? InsuredFirstName { get; set; }
        public string? InsuredLastName { get; set; }
        public string? InsuredAddress1 { get; set; }
        public string? InsuredAddress2 { get; set; }
        public string? InsuredAddress3 { get; set; }
        public string? InsuredAddress4 { get; set; }
        public string? InsuredEmail { get; set; }
        public string? Telephone { get; set; }
        public string? WorkTelephone { get; set; }
        public string? Mobile { get; set; }
        public int? PreferredMethodOfContact { get; set; }
        public int? Insured2TitleId { get; set; }
        public string? Insured2FirstName { get; set; }
        public string? Insured2LastName { get; set; }
        public string? Insured2Contact { get; set; }
        public string? DeliveryAddress1 { get; set; }
        public string? DeliveryAddress2 { get; set; }
        public string? DeliveryAddress3 { get; set; }
        public string? DeliveryAddress4 { get; set; }
        public bool? CollectExcess { get; set; }
        public decimal? PolicyExcess { get; set; }
        public decimal? SingleArticleLimit { get; set; }
        public string? SpecialInstructions { get; set; }
        public DateTime? IncidentDate { get; set; }
        public string? Lareference { get; set; }
        public int? LossAdjusterId { get; set; }
        public int? PerilId { get; set; }
        public int? PerilDetailId { get; set; }
        public int? SbsclaimId { get; set; }
        public string? Guid { get; set; }
        public string? InvoiceRef { get; set; }
        public DateTime? PaidDate { get; set; }
        public bool? RetrospectiveInstruction { get; set; }
        public bool? Isvatregistered { get; set; }
        public string? VatregistrationNumber { get; set; }
        public bool? Traditional { get; set; }
        public string? LossDescription { get; set; }
        public string? PolicyType { get; set; }
        public string? PolicySubType { get; set; }
        public string? ContactTimes { get; set; }
        public string? LossAddress { get; set; }
        public string? HandlerNameAndDepartment { get; set; }
        public string? ClaimHistory { get; set; }
        public bool? ProofOfPurchaseObtained { get; set; }
        public string? DetailsOfOtherSupplierInvolved { get; set; }
        public DateTime? DateReported { get; set; }
        public bool? Vulnerable { get; set; }
        public string? VulnerableDescription { get; set; }
        public decimal? ViablesLimit { get; set; }
        public decimal? HandlersAuthorityLimit { get; set; }
        public string? ServiceNumber { get; set; }
        public DateTime? PolicyInceptionDate { get; set; }
        public int? InstructionType { get; set; }
        public string? CrimeReference { get; set; }
        public decimal? TotalSumInsured { get; set; }
        public bool? DeductExcessFromVoucher { get; set; }
        public int? PreferedMethodOfContact { get; set; }
        public string? ServiceRequestPublicId { get; set; }
        public bool RequiresAuth { get; set; }
        public bool IsBaggageClaim { get; set; }
        public decimal? ExcessDeducted { get; set; }
        public int? AgencyReference { get; set; }
        public decimal? TotalExcess { get; set; }
        public string? DuckCreekClaimRef { get; set; }
        public bool? WasEmailSent { get; set; }

        public virtual ClaimItem2? LeadItem { get; set; }
        public virtual ICollection<ClaimItem2> ClaimItem2s { get; set; }
        public virtual ICollection<TriageOutcome> TriageOutcomes { get; set; }
    }
}
