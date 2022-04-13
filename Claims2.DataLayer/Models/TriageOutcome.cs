using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class TriageOutcome
    {
        public int TriageOutcomeId { get; set; }
        public int ValidationClaimId { get; set; }
        public DateTime DateCreated { get; set; }
        public string Action { get; set; } = null!;
        public string Questions { get; set; } = null!;

        public virtual Claim1 ValidationClaim { get; set; } = null!;
    }
}
