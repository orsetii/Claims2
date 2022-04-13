using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class IInspection
    {
        public int InsuranceClaimId { get; set; }
        public int LossAdjusterId { get; set; }
        public string? Bmonth { get; set; }
        public int? MiCat { get; set; }
    }
}
