using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BastionPolicyMi
    {
        public int Id { get; set; }
        public int InsuranceClaimId { get; set; }
        public string PolicyStartDate { get; set; } = null!;
        public string PolicyDamageCover { get; set; } = null!;
        public string PolicyLossCover { get; set; } = null!;
        public string PolicyTheftCover { get; set; } = null!;
        public string? PolicyCoverValue { get; set; }
        public string? PolicyDeductible { get; set; }
        public string? PolicyOriginalInceptionDate { get; set; }
    }
}
