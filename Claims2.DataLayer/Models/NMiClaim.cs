using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NMiClaim
    {
        public string? Consignment { get; set; }
        public int InsuranceClaimId { get; set; }
        public string AliasInsuranceClaimId { get; set; } = null!;
        public string VendorCode { get; set; } = null!;
        public DateTime DateInstructed { get; set; }
        public int? InsuranceCompanyId { get; set; }
        public int LossAdjusterId { get; set; }
        public string Lareference { get; set; } = null!;
        public int? DeliveryCompany { get; set; }
        public string? InspectionReference { get; set; }
        public string? PolicyNumber { get; set; }
        public int StatusId { get; set; }
        public int? StatusSublevelId { get; set; }
        public string? Handler { get; set; }
        public int UserId { get; set; }
        public int CauseTypeId { get; set; }
        public int? SubCauseTypeId { get; set; }
        public decimal PolicyExcess { get; set; }
        public decimal Betterment { get; set; }
        public decimal Carriage { get; set; }
        public decimal? ClaimValue { get; set; }
        public decimal InvoiceValue { get; set; }
        public decimal InvoiceCarriage { get; set; }
        public decimal Povalue { get; set; }
        public decimal Pocarriage { get; set; }
        public decimal Profit { get; set; }
        public int Items { get; set; }
        public string? AccountRef { get; set; }
        public bool IsInsuredAcompany { get; set; }
        public string? InsuredCompanyName { get; set; }
        public bool IsVatregistered { get; set; }
        public string? VatregistrationNumber { get; set; }
        public string? InsuredTitle { get; set; }
        public string? InsuredFirstName { get; set; }
        public string? InsuredLastName { get; set; }
        public string? InsuredName { get; set; }
        public string? Insured2Title { get; set; }
        public string? Insured2FirstName { get; set; }
        public string? Insured2LastName { get; set; }
        public string? Insured2Name { get; set; }
        public string? InsuredAddress1 { get; set; }
        public string? InsuredAddress2 { get; set; }
        public string? InsuredAddress3 { get; set; }
        public string? InsuredAddress4 { get; set; }
        public string? InsuredPostCode { get; set; }
        public int? InsuredConutryId { get; set; }
        public string? InsuredContactPerson { get; set; }
        public bool DeliveryAddressSameAsInsured { get; set; }
        public string? DeliveryName { get; set; }
        public string? DeliveryAddress1 { get; set; }
        public string? DeliveryAddress2 { get; set; }
        public string? DeliveryAddress3 { get; set; }
        public string? DeliveryAddress4 { get; set; }
        public string? DeliveryPostCode { get; set; }
        public int? DeliveryCountryId { get; set; }
        public string? DeliveryContactPerson { get; set; }
        public string? DeliveryTelephone { get; set; }
        public string? Telephone { get; set; }
        public string? HomeTelephone { get; set; }
        public string? WorkTelephone { get; set; }
        public string? Mobile { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Website { get; set; }
        public bool? Finalise { get; set; }
        public DateTime? FinaliseDate { get; set; }
        public string? FinaliseBy { get; set; }
        public bool? InvPhReq { get; set; }
        public DateTime? InvPhReqDate { get; set; }
        public bool? InvPhSync { get; set; }
        public DateTime? InvPhSyncDate { get; set; }
        public bool? InvPhRaised { get; set; }
        public DateTime? InvPhRaisedDate { get; set; }
        public bool? InvPhVat { get; set; }
        public string? InvPhSage { get; set; }
        public string? InvVatPhSage { get; set; }
        public bool? CreditPhReq { get; set; }
        public DateTime? CreditPhReqDate { get; set; }
        public bool? CreditPhSync { get; set; }
        public DateTime? CreditPhSyncDate { get; set; }
        public bool? CreditPhRaised { get; set; }
        public DateTime? CreditPhRaisedDate { get; set; }
        public bool? CreditPhVat { get; set; }
        public string? CreditPhSage { get; set; }
        public string? Tag { get; set; }
        public string? Comments { get; set; }
        public string? AccidentComments { get; set; }
        public string? InspectionComments { get; set; }
        public string? QuoteComments { get; set; }
        public int ItemTypeId { get; set; }
        public string? ClaimDetails { get; set; }
        public string Ipaddress { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public DateTime DateModified { get; set; }
        public DateTime? LastActionDate { get; set; }
        public bool Xspaid { get; set; }
        public string? XschangedBy { get; set; }
        public DateTime? DateXschanged { get; set; }
        public int? ClaimTypeId { get; set; }
        public bool? TechnicalClaim { get; set; }
        public bool Fnolaccepted { get; set; }
        public decimal? SingleArticleLimit { get; set; }
    }
}
