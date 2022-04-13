using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class IInspectOutcome
    {
        public int InsuranceClaimId { get; set; }
        public int LossAdjusterId { get; set; }
        public string? Bmonth { get; set; }
        public int? MiCat { get; set; }
        public int SOutcomeId { get; set; }
        public int SInspCo { get; set; }
        public string? SInspCoDesc { get; set; }
        public int? SInspUserId { get; set; }
        public int? SInspSupplierId { get; set; }
    }
}
