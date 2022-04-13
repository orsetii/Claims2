using System;
using System.Collections.Generic;

namespace Claims2.DataLayer.Models
{
    public partial class ProfitClaimDate
    {
        public int Id { get; set; }
        public int ClaimId { get; set; }
        public DateTime ProfitDate { get; set; }
        public string? Reason { get; set; }
    }
}
