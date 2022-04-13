using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SInsuranceShow
    {
        public int SClaimItemId { get; set; }
        public int? SInsuranceclaimid { get; set; }
        public int? InsuranceCompanyId { get; set; }
        public string? InsuranceCompany { get; set; }
        public string ProductCode { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string? SStatusDesc { get; set; }
        public string? SFContact { get; set; }
        public string? SFPostcode { get; set; }
        public string? SFPhone { get; set; }
        public int? SStatus { get; set; }
        public DateTime? SCreatedon { get; set; }
        public string? PolicyNumber { get; set; }
        public int AliasInsuranceClaimId { get; set; }
        public string VendorCode { get; set; } = null!;
        public DateTime DateInstructed { get; set; }
        public int LossAdjusterId { get; set; }
        public string Lareference { get; set; } = null!;
        public string? InspectionReference { get; set; }
        public string? AccountRef { get; set; }
    }
}
