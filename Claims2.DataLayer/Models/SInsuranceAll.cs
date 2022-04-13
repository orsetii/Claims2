using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class SInsuranceAll
    {
        public int SClaimItemId { get; set; }
        public int? SClaimorderid { get; set; }
        public int? SInsuranceclaimid { get; set; }
        public int? SProductid { get; set; }
        public int? SSupplierid { get; set; }
        public int? SItemtypeid { get; set; }
        public string? SCreatedby { get; set; }
        public int SInspectionId { get; set; }
        public int? SInspItem { get; set; }
        public string ProductCode { get; set; } = null!;
        public int? STlId { get; set; }
        public int? SSlId { get; set; }
        public int? SStatus { get; set; }
        public int? SOutcome { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string? UpdatedBy { get; set; }
        public string? Outcome { get; set; }
        public string Lareference { get; set; } = null!;
        public int? InsuranceCompanyId { get; set; }
        public int StatusId { get; set; }
        public string? Description { get; set; }
        public string ClaimStatus { get; set; } = null!;
        public int? SFaultType { get; set; }
        public string Inspectiontype { get; set; } = null!;
        public DateTime? SCreatedon { get; set; }
        public int? Mcreated { get; set; }
        public string? SStatusDesc { get; set; }
        public int? SInspSupplierId { get; set; }
        public int SOutcomeId { get; set; }
        public string? AccountRef { get; set; }
    }
}
