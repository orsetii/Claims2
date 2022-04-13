using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    /// <summary>
    /// A table of all insurance claims
    /// </summary>
    public partial class InsuranceClaim
    {
        public InsuranceClaim()
        {
            ClaimItem1s = new HashSet<ClaimItem1>();
        }

        public int InsuranceClaimId { get; set; }
        public int? InstructionId { get; set; }
        public int? FnolinstructionId { get; set; }
        public int? InsuranceCompanyId { get; set; }
        public int LossAdjusterId { get; set; }
        public string? LossAdjusterRef { get; set; }
        public string? PolicyNumber { get; set; }
        public string? LossAdjusterHandler { get; set; }
        public DateTime DateInstructed { get; set; }
        public DateTime? DateContacted { get; set; }
        public int? Commodity { get; set; }
        public int? Product { get; set; }
        public int? Peril { get; set; }
        public int? PerilDetails { get; set; }
        public string? ClaimDetails { get; set; }
        public int? ClaimantId { get; set; }
        public bool Closed { get; set; }
        public DateTime? DateClosed { get; set; }
        public bool HadInspection { get; set; }
        public bool HadReplacement { get; set; }
        public bool HadRepair { get; set; }
        public int? OutcomeId { get; set; }
        public string Source { get; set; } = null!;

        public virtual ICollection<ClaimItem1> ClaimItem1s { get; set; }
    }
}
