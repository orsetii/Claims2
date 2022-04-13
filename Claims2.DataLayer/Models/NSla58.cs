using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class NSla58
    {
        public int InsuranceClaimId { get; set; }
        public int IStatusSlHistStatusId { get; set; }
        public string? Std1 { get; set; }
        public int? Tdiff { get; set; }
        public DateTime? IStatusSlHistDate { get; set; }
        public DateTime? Firstdate { get; set; }
    }
}
