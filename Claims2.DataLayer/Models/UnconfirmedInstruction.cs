using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class UnconfirmedInstruction
    {
        public int InstructionId { get; set; }
        public DateTime DateCreated { get; set; }
        public int LossAdjusterId { get; set; }
        public int? InsuranceCompanyId { get; set; }
        public string RefNo { get; set; } = null!;
        public string? PolicyNo { get; set; }
        public string Handler { get; set; } = null!;
        public double? PolicyExcess { get; set; }
        public double? SingleArticleLimitAmount { get; set; }
        public bool? SingleArticleLimit { get; set; }
        public string? AccidentDetails { get; set; }
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Address4 { get; set; }
        public string? PostCode { get; set; }
        public string? Title2 { get; set; }
        public string? FirstName2 { get; set; }
        public string? LastName2 { get; set; }
        public string? DelivAddress1 { get; set; }
        public string? DelivAddress2 { get; set; }
        public string? DelivAddress3 { get; set; }
        public string? DelivAddress4 { get; set; }
        public string? DelivPostCode { get; set; }
        public string? HomePhone { get; set; }
        public string? WorkPhone { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public bool? IsAcompany { get; set; }
        public bool? IsVatregistered { get; set; }
        public string? CompanyName { get; set; }
        public string? VatRegNo { get; set; }
        public DateTime? DateConfirmed { get; set; }
        public int? ConfirmedInstructionId { get; set; }
        public string? ConfirmedBy { get; set; }
        public string? Source { get; set; }
        public int? LeadItem { get; set; }
        public int? AppMessageId { get; set; }
    }
}
