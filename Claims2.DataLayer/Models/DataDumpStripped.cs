using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class DataDumpStripped
    {
        public int ClaimId { get; set; }
        public string? PolicyNumber { get; set; }
        public string? LossAdjusterName { get; set; }
        public string? ReasonForClaim { get; set; }
        public string? CauseOfDamage { get; set; }
        public string Sbshandler { get; set; } = null!;
        public string? LeadItemCommodity { get; set; }
        public string? ClaimAuthorityType { get; set; }
        public string? InsuredSurname { get; set; }
        public string? InsuredPostcode { get; set; }
        public string Vatregistered { get; set; } = null!;
        public string? InsuranceCompany { get; set; }
        public DateTime DateOpened { get; set; }
        public string? Peril { get; set; }
        public string? ItemOutcome { get; set; }
        public string? ClaimOutcome { get; set; }
        public DateTime? TelesaleAdded { get; set; }
        public string? Supplier { get; set; }
        public decimal? BuyRate { get; set; }
        public decimal? CostOfDelivery { get; set; }
        public string? Description { get; set; }
        public decimal? SaleWithoutVat { get; set; }
        public decimal? SaleWithVat { get; set; }
        public decimal? Rrp { get; set; }
        public int? Quantity { get; set; }
        public string? PoNumber { get; set; }
        public DateTime? OrderPlaced { get; set; }
        public int? ConfirmedBySupplier { get; set; }
        public DateTime? AgreedDeliveryDate { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }
        public string? ItemType { get; set; }
        public string? LineItemCategory { get; set; }
        public int? Mimonth { get; set; }
        public int? Miyear { get; set; }
    }
}
