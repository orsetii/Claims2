using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class OldTempInsuranceClaim
    {
        public int? AliasInsuranceClaimId { get; set; }
        public int? InsuranceCompanyId { get; set; }
        public int? LossAdjusterId { get; set; }
        public string? Lareference { get; set; }
        public int? UserId { get; set; }
        public DateTime? InstrDate { get; set; }
        public string? ClientLastName { get; set; }
        public int StatusId { get; set; }
        public int StatusSubLevelId { get; set; }
        public string? Handler { get; set; }
        public string? PolicyNumber { get; set; }
        public decimal? PolicyExcess { get; set; }
        public decimal? Betterment { get; set; }
        public decimal? Carriage { get; set; }
        public decimal? ClaimValue { get; set; }
        public int ItemTypeId { get; set; }
        public int CauseTypeId { get; set; }
        public int SubCauseTypeId { get; set; }
        public string? ClaimDetails { get; set; }
        public string? AccidentComments { get; set; }
        public string VendorCode { get; set; } = null!;
        public string? InsuredTitle { get; set; }
        public string? InsuredFirstName { get; set; }
        public string? HomeTel { get; set; }
        public string? WorkTel { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? InsuredAddress1 { get; set; }
        public string? InsuredAddress2 { get; set; }
        public string? InsuredAddress3 { get; set; }
        public string? InsuredAddress4 { get; set; }
        public string? PostCode { get; set; }
        public int? ClaimTypeId { get; set; }
        public bool? TechnicalClaim { get; set; }
        public bool? IsInsuredAcompany { get; set; }
        public bool? IsVatregistered { get; set; }
        public string? InsuredCompanyName { get; set; }
        public string? VatregistrationNumber { get; set; }
        public string? Insured2Title { get; set; }
        public string? Insured2FirstName { get; set; }
        public string? Insured2LastName { get; set; }
        public string? DeliveryAddress1 { get; set; }
        public string? DeliveryAddress2 { get; set; }
        public string? DeliveryAddress3 { get; set; }
        public string? DeliveryAddress4 { get; set; }
        public string? DeliveryPostCode { get; set; }
        public bool? SingleArticleLimit { get; set; }
        public int? FnolitemType { get; set; }
        public int? Fnolperil { get; set; }
        public int? FnolperilDetail { get; set; }
    }
}
