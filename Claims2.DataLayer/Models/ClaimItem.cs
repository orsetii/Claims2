using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ClaimItem
    {
        public ClaimItem()
        {
            ClaimItemValues = new HashSet<ClaimItemValue>();
            InsuranceClaim1s = new HashSet<InsuranceClaim1>();
            ItemActionHistories = new HashSet<ItemActionHistory>();
            ItemInspections = new HashSet<ItemInspection>();
            ItemTaskHistories = new HashSet<ItemTaskHistory>();
        }

        public int ItemId { get; set; }
        public int? InsuranceClaimId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? DateConfirmed { get; set; }
        public bool Closed { get; set; }
        public bool ClosedAutomatically { get; set; }
        public DateTime? DateClosed { get; set; }
        public bool HadInspection { get; set; }
        public bool HadReplacement { get; set; }
        public bool HadRepair { get; set; }
        public int? OutcomeId { get; set; }
        public int ItemTypeId { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? SerialNo { get; set; }
        public int? ActionId { get; set; }
        /// <summary>
        /// This is a temporary column that will help to keep track of which items have already been created for the new inspection system
        /// </summary>
        public int? OldInspectionId { get; set; }
        public int? PerilId { get; set; }
        public int? PerilDetailId { get; set; }
        public int PhaseId { get; set; }
        public int? InsurersInstructionId { get; set; }
        public int? FinalOutcomeId { get; set; }
        public string? ReopeningReason { get; set; }
        public int Deleted { get; set; }
        public int? ProductId { get; set; }
        public int? ProductItemId { get; set; }
        public int? SuggestedReplacement { get; set; }
        public double? SuggestedReplacementPrice { get; set; }
        public string? Description { get; set; }
        public string? PartCode { get; set; }
        public double? PurchasePrice { get; set; }
        public int? ParentClaimItemId { get; set; }
        public int? ValidationClaimItemId { get; set; }

        public virtual InsuranceClaim1? InsuranceClaim { get; set; }
        public virtual Value1 ItemType { get; set; } = null!;
        public virtual Value1? Peril { get; set; }
        public virtual Value1? PerilDetail { get; set; }
        public virtual ICollection<ClaimItemValue> ClaimItemValues { get; set; }
        public virtual ICollection<InsuranceClaim1> InsuranceClaim1s { get; set; }
        public virtual ICollection<ItemActionHistory> ItemActionHistories { get; set; }
        public virtual ICollection<ItemInspection> ItemInspections { get; set; }
        public virtual ICollection<ItemTaskHistory> ItemTaskHistories { get; set; }
    }
}
