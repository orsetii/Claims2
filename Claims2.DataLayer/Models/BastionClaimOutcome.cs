using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class BastionClaimOutcome
    {
        public int Id { get; set; }
        public int InsuranceClaimId { get; set; }
        public int OutcomeId { get; set; }
    }
}
