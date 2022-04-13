using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class AxaBastionreport
    {
        public string? CountryCode { get; set; }
        public string? Cur { get; set; }
        public string? PolicyNumber { get; set; }
        public string? AxaClaimNumber { get; set; }
        public string? Underwriter { get; set; }
        public string? InsuranceCompanyName { get; set; }
        public DateTime? PolicyStartDate { get; set; }
        public string? PolicyCover { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerSurname { get; set; }
        public string? TpaId { get; set; }
        public int? ClaimNumber { get; set; }
        public DateTime? ClaimOccurenceDate { get; set; }
        public string? NotificationChannel { get; set; }
        public DateTime? ClaimNotificationDate { get; set; }
        public string? ClaimCover { get; set; }
        public string? ClaimDecision { get; set; }
        public string? WithdrawalDeclinatureReason { get; set; }
        public DateTime? DecisionDate { get; set; }
        public string? FraudSuspicion { get; set; }
        public string? FraudSuspicion1 { get; set; }
        public string? MaximumCoverAmount { get; set; }
        public string? Deductible { get; set; }
        public string? ClaimReserve { get; set; }
        public string? ProductGroup { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? ImeiSn { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string? PurchasePrice { get; set; }
        public string? SupplierName { get; set; }
        public string? RepairerJobNo { get; set; }
        public string? ServiceStatus { get; set; }
        public DateTime? StatusDate { get; set; }
        public string? InboundLogisticsTrackingId { get; set; }
        public string? PickUpDate { get; set; }
        public string? OutboundLogisticsTrackingId { get; set; }
        public string? DeliveryDate { get; set; }
        public string? EndToEndTatDays { get; set; }
        public DateTime? ExcessCollectedDate { get; set; }
        public string? ExcessCollectedFromCashSettlement { get; set; }
        public DateTime? LatestInvoiceDate { get; set; }
        public string? ClaimEstimateTotalCostGrossOfExcess { get; set; }
        public string? ClaimEstimateTotalCostNetOfExcess { get; set; }
        public string? ReserveUsedInCalc { get; set; }
        public string? TotalClaimCostNetOfExcessCollected { get; set; }
        public string? TotalClaimCostGrossOfExcessCollected { get; set; }
        public string? TotalServiceCostVat { get; set; }
        public string? ExcessCollected { get; set; }
        public string? TpaValidationFee { get; set; }
        public string? RepairCost { get; set; }
        public string? RepairVat { get; set; }
        public string? ReplacementCost { get; set; }
        public string? ReplacementVat { get; set; }
        public string? LogisticsNoOfLegs { get; set; }
        public string? ComplaintClaim { get; set; }
        public string? Justified { get; set; }
        public string? RepairerService { get; set; }
        public string? ClaimType { get; set; }
        public string? DetailedClaimDescriptionLimitedTo300Characters { get; set; }
        public DateTime? ClaimClosedDate { get; set; }
        public string? RejectionReasonCode { get; set; }
        public string? WithdrawnReasonCode { get; set; }
        public string? ClaimExcluded { get; set; }
        public string? ReplacementModel { get; set; }
        public string? ReplacementMake { get; set; }
        public string? ReplacementImeiSn { get; set; }
    }
}
