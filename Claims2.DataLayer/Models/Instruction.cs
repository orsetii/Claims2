using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class Instruction
    {
        public int SbsRef { get; set; }
        public int? LossAdjuster { get; set; }
        public int? InsuranceCompanyId { get; set; }
        public string? RefNo { get; set; }
        public string? RefName { get; set; }
        public int? AddedBy { get; set; }
        public string? AddedByName { get; set; }
        public int? SalesPerson { get; set; }
        public int? Method { get; set; }
        public DateTime? Arrived { get; set; }
        public DateTime? PickedUp { get; set; }
        public bool? Deleted { get; set; }
        public double? Timelapse { get; set; }
        public string? MonthIns { get; set; }
        /// <summary>
        /// For now, 0 -&gt; Insurance claim instruction, 1 -&gt; Warranty claim instruction
        /// </summary>
        public int Type { get; set; }
        public string? PolicyNumber { get; set; }
        public string? ClaimHandler { get; set; }
        public int? ItemTypeId { get; set; }
        public int? CauseTypeId { get; set; }
        public int? SubCauseTypeId { get; set; }
        public int? ClaimTypeId { get; set; }
        public string? DamageDetails { get; set; }
        public bool? TechnicalClaim { get; set; }
        public bool? Company { get; set; }
        public bool? VatRegd { get; set; }
        public string? CompanyName { get; set; }
        public string? VatregNo { get; set; }
        public decimal? Excess { get; set; }
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? Title2 { get; set; }
        public string? FirstName2 { get; set; }
        public string? LastName2 { get; set; }
        public string? HomeTel { get; set; }
        public string? WorkTel { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Address4 { get; set; }
        public string? PostCode { get; set; }
        public string? Ipaddress { get; set; }
        public string? DelivAddress1 { get; set; }
        public string? DelivAddress2 { get; set; }
        public string? DelivAddress3 { get; set; }
        public string? DelivAddress4 { get; set; }
        public string? DelivPostCode { get; set; }
        public bool? SingleArticleLimit { get; set; }
        public decimal? SingleArticleLimitAmount { get; set; }
    }
}
