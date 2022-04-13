using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ItemInspection
    {
        public ItemInspection()
        {
            InspectionImages = new HashSet<InspectionImage>();
            ItemRepairs = new HashSet<ItemRepair>();
            RepairPartsCosts = new HashSet<RepairPartsCost>();
            ReplacementItemsCosts = new HashSet<ReplacementItemsCost>();
        }

        public int InspectionId { get; set; }
        public int ClaimItemId { get; set; }
        public int? AgentId { get; set; }
        public DateTime DateReceived { get; set; }
        public int? InspectionTypeId { get; set; }
        public DateTime? DateReported { get; set; }
        public string? Report { get; set; }
        public string? Concerns { get; set; }
        public string? Comments { get; set; }
        public bool? Repairable { get; set; }
        public double? RepairLabourHours { get; set; }
        public double? RepairLabourCost { get; set; }
        public int? EtarepairComplete { get; set; }
        public int? StatusId { get; set; }
        public int? ActionId { get; set; }
        public int? OutcomeId { get; set; }
        public DateTime? CallBookedDate { get; set; }
        public bool? CallMadeIfDifferent { get; set; }
        public bool? CauseWearTear { get; set; }
        public double? DisconnectionQuote { get; set; }
        public double? InstallationQuote { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Address4 { get; set; }
        public string? Postcode { get; set; }
        public DateTime LastModified { get; set; }
        public bool Closed { get; set; }
        public bool? Read { get; set; }
        public string? HandlerReply { get; set; }
        public int? OldInspectionId { get; set; }
        public bool? Quarantine { get; set; }
        public int? QuarantineDays { get; set; }
        public DateTime? QuarantineStart { get; set; }
        public DateTime? QuarantineEnd { get; set; }
        public bool? Backup { get; set; }
        public DateTime? BackupDate { get; set; }
        public string? BackupDetails { get; set; }
        public bool PrintedByHandler { get; set; }
        public bool Alerted { get; set; }
        public bool OldInspectionFlag { get; set; }
        public bool TempUpdated { get; set; }
        public int? DeliveryReference { get; set; }
        public int? DeliveryCompany { get; set; }
        public int? DeliveryDate { get; set; }
        public string? Guid { get; set; }
        public string? SummaryOfInstruction { get; set; }
        public string? SpecialInstructions { get; set; }
        public string? Recommendation { get; set; }
        public DateTime? FittingDate { get; set; }
        public DateTime? InspectionScheduled { get; set; }

        public virtual ClaimItem ClaimItem { get; set; } = null!;
        public virtual ICollection<InspectionImage> InspectionImages { get; set; }
        public virtual ICollection<ItemRepair> ItemRepairs { get; set; }
        public virtual ICollection<RepairPartsCost> RepairPartsCosts { get; set; }
        public virtual ICollection<ReplacementItemsCost> ReplacementItemsCosts { get; set; }
    }
}
